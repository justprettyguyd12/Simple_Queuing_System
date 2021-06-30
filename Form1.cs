using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Modeling_5
{
    public partial class Form1 : Form
    {
        int time = 0; // просто для меня показывает счетчик таймера
        bool isWork;

        //параметры СМО
        int size_queue;
        int chance;
        int interval_request_min;
        int interval_request_max;
        int time_request_min;
        int time_request_max;
        int time_sd;

        //переменные для статистики
        int statistic_max_count; //максимальная длина очереди
        int statistic_sum_count; //сумма длин очередей 
        double statistic_average_count; //средняя длина очереди
        int statistic_inSD; //заявок прошло в ПО
        int statistic_sum_wait; //сумма времени ожидания
        int statictic_max_SD; //максимальное время работы ПО
        int statistic_sum_inSD; //сумма времени работы ПО
        int statistic_t1; //начало простоя ПО
        bool start_idle; //начался ли простой
        bool finish_idle; //кончился ли простой
        int statistic_t2; //конец простоя ПО


        //класс заявки
        public class Request
        {
            public Request(int number, bool isLow, int time_coming)
            {
                this.number = number;
                this.isLow = isLow;
                this.time_coming = time_coming;
            }

            public string GetString()
            {
                string s = "№: " + number.ToString();
                s += isLow == true ? "; приоритетность низкая" : "; приоритетность высокая";
                s += "; время создания: " + this.time_coming.ToString();
                return s;
            }

            public int number;
            public bool isLow;
            public int time_coming; 
        }

        List<Request> requests; //список заявок
        Request[] InSD;
        int count_requests; //количество созданных заявок

        Random random = new Random();
        System.Threading.Timer timer_request; //таймер подачи заявок
        System.Threading.Timer timer_SD; //таймер обработки заявок
        System.Threading.Timer progress_timer; //таймер для загрузочной анимации

        public Form1()
        {
            InitializeComponent();
            isWork = false;
            //инициализация всех настроек
            timer1.Interval = Convert.ToInt32(Interval.Text);
            size_queue = (int)Size_Queue.Value;
            chance = (int)Chance_Low_Priority.Value;
            interval_request_min = (int)Interval_Request_Min.Value;
            interval_request_max = (int)Interval_Request_Max.Value;
            time_request_min = (int)Time_Request_Min.Value;
            time_request_max = (int)Time_Request_Max.Value;
            chance = (int)Chance_Low_Priority.Value;
        }

        //старт СМО
        private void Start_Button_Click(object sender, EventArgs e)
        {

            //инициализация статистических переменных
            statistic_max_count = 0;
            statistic_sum_count = 0;
            statistic_average_count = 0;
            statistic_inSD = 0;
            statistic_sum_wait = 0;
            statictic_max_SD = 0;
            statistic_sum_inSD = 0;
            statistic_t1 = 0;
            start_idle = false;
            finish_idle = false;
            statistic_t2 = 0;

            //инициализация полей данных
            requests = new List<Request>(); //создание новой очереди
            InSD = new Request[1]; //создание нового ПО
            count_requests = 0; //обнуление количества созданных заявок

            //запуск всех таймеров

            //таймер для обновления формы, интервал задаётся на форме
            timer1.Start();

            //таймер появления заявок, задаётся на форме
            int t = random.Next(interval_request_min, interval_request_max);
            Time_New_Request.Text = t.ToString(); 
            var autoEvent = new AutoResetEvent(false);
            timer_request = new System.Threading.Timer(CreateRequest, autoEvent, t,
                t);

            //таймер обработки заявок, задаётся на форме
            //преобразовывается в экспоненциальный закон распределения со скоростью 4,7
            t = Convert.ToInt32(time_request_min +
                (Math.Log(1.00 - random.NextDouble()) / -4.7) * (time_request_max - time_request_min));
            time_sd = t;
            if (statictic_max_SD < t)
                statictic_max_SD = t;
            Time_Work_Request.Text = t.ToString();
            timer_SD = new System.Threading.Timer(ProcessRequest, autoEvent, t,
                t);

            isWork = true;
        }

        //счетчик на экране - обновляет данные формы
        private void timer1_Tick(object sender, EventArgs e)
        {
            //общее время работы СМО
            time += timer1.Interval;

            //обновление всех полей формы
            Max_Time_SD.Text = statictic_max_SD.ToString();
            try
            {
                Average_Time_SD.Text = (statistic_sum_inSD / statistic_inSD).ToString();
            }
            catch { }

            Time_Of_Work.Text = time.ToString();

            requests_List.Items.Clear();
            foreach (Request r in requests.ToArray())
            {
                requests_List.Items.Add(r.GetString());
            }
            foreach (Request r in InSD)
            {
                if (r != null)
                {
                    Request_In_SD.Text = r.GetString();
                }
                else
                    Request_In_SD.Text = "";
            }
        }

        //завершение работы СМО
        private void Stop_Click(object sender, EventArgs e)
        {
            //сброс таймеров
            timer1.Stop();
            timer_request.Dispose();
            timer_SD.Dispose();
            progress_timer.Dispose();
            time = 0;

            //обнуление всех полей на форме;
            Time_Of_Work.Text = time.ToString();
            Time_Coming_Request.Clear();
            Time_Work_Request.Clear();
            Time_Waiting_Request.Clear();
            Count_Queue.Clear();
            Max_Count_Queue.Clear();
            Average_Count_Queue.Clear();
            Average_Time_Queue.Clear();
            Max_Time_SD.Clear();
            Average_Time_SD.Clear();
            Wait_Time_SD.Clear();
            requests_List.Items.Clear();
            Request_In_SD.Clear();
            progressBar1.Value = 0;
            Time_New_Request.Clear();

            isWork = false;
        }

        //создание заявки
        private void CreateRequest(object state)
        {
            if (requests.Count < size_queue) //проверка ограничения по длине очереди
            {
                //добавление заявки
                requests.Add(new Request(count_requests, random.Next(0, 100) < chance, time));
                count_requests++;

                //обновление статистики
                if (statistic_max_count < requests.Count)
                    statistic_max_count++;
                statistic_sum_count += requests.Count();
                statistic_average_count = Convert.ToDouble(statistic_sum_count) / Convert.ToDouble(count_requests);


                int t = random.Next(interval_request_min, interval_request_max);

                //запуск анимации загрузки
                Invoke((Action)(() => Time_New_Request.Text = t.ToString()));

                timer_request.Change(t, random.Next(t, t));
                ProcessRequest(state); //сразу запускает заявку в ПО

                //обновление статистки по очереди
                Invoke((Action)(() =>
                {
                    Count_Queue.Text = requests.Count().ToString(); //текущая длина очереди
                    Max_Count_Queue.Text = statistic_max_count.ToString(); //максимальная набранная длина очереди
                    Average_Count_Queue.Text = statistic_average_count.ToString();
                }
                ));
            }
        }

        //обработка заявки в ПО
        private void ProcessRequest(object state)
        {
            if (requests.Count != 0 && InSD[0] == null) //очередь не пуста и ПО свободен
            {
                if (start_idle) //проверка наличия простоя ПО
                {
                    statistic_t2 += time - statistic_t1;
                    start_idle = false;
                    //вывод времени простоя ПО
                    Invoke((Action)(() => Wait_Time_SD.Text = statistic_t2.ToString()));
                }
                
                InSD[0] = SelectRequest();
                requests.Remove(InSD[0]);

                //обновление статистики
                statistic_inSD++;
                int wait = time - InSD[0].time_coming;
                statistic_sum_wait += wait;

                //обновление полей статистики заявки в ПО
                Invoke((Action)(() =>
                {
                    Time_Coming_Request.Text = InSD[0].time_coming.ToString(); //время прибытия
                    Time_Waiting_Request.Text = (wait).ToString(); //время простоя
                    Count_Queue.Text = requests.Count().ToString(); //текущая длина очереди
                    Average_Time_Queue.Text = (statistic_sum_wait / statistic_inSD).ToString();
                }
                ));
                //запуск процессов
                var autoEvent = new AutoResetEvent(false);
                progress_timer = new System.Threading.Timer(ProgressStep, autoEvent, 
                    0, time_sd / 10);

                //обновление интервала таймера ПО
                int t = Convert.ToInt32(time_request_min +
                    (Math.Log(1.00 - random.NextDouble()) / -4.7) * (time_request_max - time_request_min));
                timer_SD.Change(t, Convert.ToInt32(time_request_min +
                    (Math.Log(1.00 - random.NextDouble()) / -4.7) * (time_request_max - time_request_min)));

                //обновление статистики
                if (statictic_max_SD < t)
                {
                    statictic_max_SD = t;
                }
                statistic_sum_inSD += t;

                //обновление формы
                Invoke((Action)(() => Time_Work_Request.Text = t.ToString()));
            }
        }

        //процесс обработки
        private void ProgressStep(object state)
        {
            Invoke((Action)(() =>
            {
                if (progressBar1.Value <= 9)
                {
                    progressBar1.Value++;
                    Thread.Sleep(0);
                }
                
                else
                {
                    progressBar1.Value = 0;
                    progress_timer.Dispose();
                    Invoke((Action)(() => InSD = new Request[1])); //обнуление массива
                    start_idle = true;
                    statistic_t1 = time;
                }
            }
            ));
        }

        //изменение параметров СМО
        private void Change_Data(object sender, EventArgs e)
        {
            //обработчик для изменения каких-либо параметров во время выполнения
            switch (((NumericUpDown)sender).Name)
            {
                //параметры интервалов
                case "Interval_Request_Min":
                    interval_request_min = (int)((NumericUpDown)sender).Value;
                    int t = random.Next(interval_request_min, interval_request_max);
                    if (isWork)
                        timer_request.Change(t, t);
                    return;

                case "Interval_Request_Max":
                    interval_request_max = (int)((NumericUpDown)sender).Value;
                    Interval_Request_Min.Maximum = interval_request_max;
                    if (isWork)
                    {
                        time_sd = random.Next(interval_request_min, interval_request_max);
                        timer_request.Change(time_sd, time_sd);
                    }
                    return;

                case "Time_Request_Min":
                    time_request_min = (int)((NumericUpDown)sender).Value;
                    if (isWork)
                    {
                        time_sd = Convert.ToInt32(time_request_min + (Math.Log(1.00 - random.NextDouble()) / -4.7) *
                        (time_request_max - time_request_min));
                        if (statictic_max_SD < time_sd)
                            statictic_max_SD = time_sd;
                        timer_SD.Change(0, time_sd);
                    }
                    return;

                case "Time_Request_Max":
                    time_request_max = (int)((NumericUpDown)sender).Value;
                    Time_Request_Min.Maximum = time_request_max;
                    if (isWork)
                    {
                        time_sd = Convert.ToInt32(time_request_min + (Math.Log(1.00 - random.NextDouble()) / -4.7) *
                        (time_request_max - time_request_min));
                        if (statictic_max_SD < time_sd)
                            statictic_max_SD = time_sd;
                        timer_SD.Change(0, time_sd);
                    }
                    return;

                //основные параметры
                case "Interval":
                    timer1.Interval = (int)((NumericUpDown)sender).Value;
                    return;

                case "Size_Queue":
                    size_queue = (int)((NumericUpDown)sender).Value;
                    return;

                case "Chance_Low_Priority":
                    chance = (int)((NumericUpDown)sender).Value;
                    return;
            }
        }

        //метод выбора заявки из очереди соответственно приоритету 
        //и дисциплине обслуживания
        private Request SelectRequest()
        {
            for (int i = 0; i < requests.Count; i++)
            {
                if (!requests[i].isLow)
                    return requests[i];
            }
            for (int i = requests.Count - 1; i >= 0; i--)
            {
                return requests[i];
            }
            return requests[0]; //костыль, до которого код никогда не дойдёт; нужен, чтобы компилятор не ругался
        }

    }
}
