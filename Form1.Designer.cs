
namespace Modeling_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Time_Waiting_Request = new System.Windows.Forms.TextBox();
            this.Time_Work_Request = new System.Windows.Forms.TextBox();
            this.Time_Coming_Request = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Wait_Time_SD = new System.Windows.Forms.TextBox();
            this.Average_Time_SD = new System.Windows.Forms.TextBox();
            this.Max_Time_SD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Average_Time_Queue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Average_Count_Queue = new System.Windows.Forms.TextBox();
            this.Max_Count_Queue = new System.Windows.Forms.TextBox();
            this.Count_Queue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Interval = new System.Windows.Forms.NumericUpDown();
            this.Chance_Low_Priority = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Size_Queue = new System.Windows.Forms.NumericUpDown();
            this.Time_Request_Max = new System.Windows.Forms.NumericUpDown();
            this.Time_Request_Min = new System.Windows.Forms.NumericUpDown();
            this.Interval_Request_Max = new System.Windows.Forms.NumericUpDown();
            this.Interval_Request_Min = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label666 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.requests_List = new System.Windows.Forms.ListBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Request_In_SD = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Time_Of_Work = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Time_New_Request = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chance_Low_Priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size_Queue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Request_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Request_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_Request_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_Request_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Time_Waiting_Request);
            this.groupBox1.Controls.Add(this.Time_Work_Request);
            this.groupBox1.Controls.Add(this.Time_Coming_Request);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры текущей заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время простоя в очереди:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Необходимое время проработки:";
            // 
            // Time_Waiting_Request
            // 
            this.Time_Waiting_Request.Enabled = false;
            this.Time_Waiting_Request.Location = new System.Drawing.Point(222, 73);
            this.Time_Waiting_Request.Name = "Time_Waiting_Request";
            this.Time_Waiting_Request.Size = new System.Drawing.Size(68, 20);
            this.Time_Waiting_Request.TabIndex = 3;
            // 
            // Time_Work_Request
            // 
            this.Time_Work_Request.Enabled = false;
            this.Time_Work_Request.Location = new System.Drawing.Point(222, 47);
            this.Time_Work_Request.Name = "Time_Work_Request";
            this.Time_Work_Request.Size = new System.Drawing.Size(68, 20);
            this.Time_Work_Request.TabIndex = 2;
            // 
            // Time_Coming_Request
            // 
            this.Time_Coming_Request.Enabled = false;
            this.Time_Coming_Request.Location = new System.Drawing.Point(222, 21);
            this.Time_Coming_Request.Name = "Time_Coming_Request";
            this.Time_Coming_Request.Size = new System.Drawing.Size(68, 20);
            this.Time_Coming_Request.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время прибытия в систему:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Wait_Time_SD);
            this.groupBox2.Controls.Add(this.Average_Time_SD);
            this.groupBox2.Controls.Add(this.Max_Time_SD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Average_Time_Queue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Average_Count_Queue);
            this.groupBox2.Controls.Add(this.Max_Count_Queue);
            this.groupBox2.Controls.Add(this.Count_Queue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 254);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистика";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "- время простоя прибора: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "- среднее время обслуживания:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "- максимальное время обслуживания: ";
            // 
            // Wait_Time_SD
            // 
            this.Wait_Time_SD.Enabled = false;
            this.Wait_Time_SD.Location = new System.Drawing.Point(218, 227);
            this.Wait_Time_SD.Name = "Wait_Time_SD";
            this.Wait_Time_SD.Size = new System.Drawing.Size(72, 20);
            this.Wait_Time_SD.TabIndex = 15;
            // 
            // Average_Time_SD
            // 
            this.Average_Time_SD.Enabled = false;
            this.Average_Time_SD.Location = new System.Drawing.Point(218, 201);
            this.Average_Time_SD.Name = "Average_Time_SD";
            this.Average_Time_SD.Size = new System.Drawing.Size(72, 20);
            this.Average_Time_SD.TabIndex = 14;
            // 
            // Max_Time_SD
            // 
            this.Max_Time_SD.Enabled = false;
            this.Max_Time_SD.Location = new System.Drawing.Point(218, 175);
            this.Max_Time_SD.Name = "Max_Time_SD";
            this.Max_Time_SD.Size = new System.Drawing.Size(72, 20);
            this.Max_Time_SD.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Относительно прибора обслуживания:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "- среднее время ожидания: ";
            // 
            // Average_Time_Queue
            // 
            this.Average_Time_Queue.Enabled = false;
            this.Average_Time_Queue.Location = new System.Drawing.Point(218, 118);
            this.Average_Time_Queue.Name = "Average_Time_Queue";
            this.Average_Time_Queue.Size = new System.Drawing.Size(72, 20);
            this.Average_Time_Queue.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Относительно очереди:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "- средняя длина: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "- максимальная длина:";
            // 
            // Average_Count_Queue
            // 
            this.Average_Count_Queue.Enabled = false;
            this.Average_Count_Queue.Location = new System.Drawing.Point(218, 92);
            this.Average_Count_Queue.Name = "Average_Count_Queue";
            this.Average_Count_Queue.Size = new System.Drawing.Size(72, 20);
            this.Average_Count_Queue.TabIndex = 3;
            // 
            // Max_Count_Queue
            // 
            this.Max_Count_Queue.Enabled = false;
            this.Max_Count_Queue.Location = new System.Drawing.Point(218, 66);
            this.Max_Count_Queue.Name = "Max_Count_Queue";
            this.Max_Count_Queue.Size = new System.Drawing.Size(72, 20);
            this.Max_Count_Queue.TabIndex = 2;
            // 
            // Count_Queue
            // 
            this.Count_Queue.Enabled = false;
            this.Count_Queue.Location = new System.Drawing.Point(218, 40);
            this.Count_Queue.Name = "Count_Queue";
            this.Count_Queue.Size = new System.Drawing.Size(72, 20);
            this.Count_Queue.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "- текущая длина: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Interval);
            this.groupBox3.Controls.Add(this.Chance_Low_Priority);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Size_Queue);
            this.groupBox3.Controls.Add(this.Time_Request_Max);
            this.groupBox3.Controls.Add(this.Time_Request_Min);
            this.groupBox3.Controls.Add(this.Interval_Request_Max);
            this.groupBox3.Controls.Add(this.Interval_Request_Min);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label666);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(314, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 227);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки";
            // 
            // Interval
            // 
            this.Interval.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Interval.Location = new System.Drawing.Point(218, 22);
            this.Interval.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Interval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(62, 20);
            this.Interval.TabIndex = 25;
            this.Interval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Interval.ValueChanged += new System.EventHandler(this.Change_Data);
            // 
            // Chance_Low_Priority
            // 
            this.Chance_Low_Priority.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Chance_Low_Priority.Location = new System.Drawing.Point(218, 72);
            this.Chance_Low_Priority.Name = "Chance_Low_Priority";
            this.Chance_Low_Priority.Size = new System.Drawing.Size(62, 20);
            this.Chance_Low_Priority.TabIndex = 24;
            this.Chance_Low_Priority.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Chance_Low_Priority.ValueChanged += new System.EventHandler(this.Change_Data);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Вероятность низкого приоритета, %: ";
            // 
            // Size_Queue
            // 
            this.Size_Queue.Location = new System.Drawing.Point(218, 46);
            this.Size_Queue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Size_Queue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Size_Queue.Name = "Size_Queue";
            this.Size_Queue.Size = new System.Drawing.Size(62, 20);
            this.Size_Queue.TabIndex = 22;
            this.Size_Queue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Size_Queue.ValueChanged += new System.EventHandler(this.Change_Data);
            // 
            // Time_Request_Max
            // 
            this.Time_Request_Max.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Time_Request_Max.Location = new System.Drawing.Point(150, 165);
            this.Time_Request_Max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Time_Request_Max.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Time_Request_Max.Name = "Time_Request_Max";
            this.Time_Request_Max.Size = new System.Drawing.Size(53, 20);
            this.Time_Request_Max.TabIndex = 21;
            this.Time_Request_Max.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Time_Request_Max.ValueChanged += new System.EventHandler(this.Change_Data);
            // 
            // Time_Request_Min
            // 
            this.Time_Request_Min.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Time_Request_Min.Location = new System.Drawing.Point(39, 165);
            this.Time_Request_Min.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Time_Request_Min.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Time_Request_Min.Name = "Time_Request_Min";
            this.Time_Request_Min.Size = new System.Drawing.Size(53, 20);
            this.Time_Request_Min.TabIndex = 20;
            this.Time_Request_Min.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Time_Request_Min.ValueChanged += new System.EventHandler(this.Change_Data);
            // 
            // Interval_Request_Max
            // 
            this.Interval_Request_Max.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Interval_Request_Max.Location = new System.Drawing.Point(148, 122);
            this.Interval_Request_Max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Interval_Request_Max.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Interval_Request_Max.Name = "Interval_Request_Max";
            this.Interval_Request_Max.Size = new System.Drawing.Size(53, 20);
            this.Interval_Request_Max.TabIndex = 19;
            this.Interval_Request_Max.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Interval_Request_Max.ValueChanged += new System.EventHandler(this.Change_Data);
            // 
            // Interval_Request_Min
            // 
            this.Interval_Request_Min.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Interval_Request_Min.Location = new System.Drawing.Point(39, 122);
            this.Interval_Request_Min.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Interval_Request_Min.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Interval_Request_Min.Name = "Interval_Request_Min";
            this.Interval_Request_Min.Size = new System.Drawing.Size(53, 20);
            this.Interval_Request_Min.TabIndex = 18;
            this.Interval_Request_Min.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Interval_Request_Min.ValueChanged += new System.EventHandler(this.Change_Data);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(114, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Max:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Min:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(138, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Время обработки заявки:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(114, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Max:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Min:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Интервал времени между заявками:";
            // 
            // label666
            // 
            this.label666.AutoSize = true;
            this.label666.Location = new System.Drawing.Point(6, 50);
            this.label666.Name = "label666";
            this.label666.Size = new System.Drawing.Size(164, 13);
            this.label666.TabIndex = 4;
            this.label666.Text = "Максимальная длина очереди:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Интервал модельного времени:";
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(314, 349);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(143, 23);
            this.Start_Button.TabIndex = 7;
            this.Start_Button.Text = "Пуск";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(457, 349);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(143, 23);
            this.Stop.TabIndex = 8;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // requests_List
            // 
            this.requests_List.FormattingEnabled = true;
            this.requests_List.Location = new System.Drawing.Point(606, 25);
            this.requests_List.Name = "requests_List";
            this.requests_List.Size = new System.Drawing.Size(315, 277);
            this.requests_List.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(719, 307);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "Прибор обслуживания";
            // 
            // Request_In_SD
            // 
            this.Request_In_SD.Location = new System.Drawing.Point(606, 323);
            this.Request_In_SD.Name = "Request_In_SD";
            this.Request_In_SD.Size = new System.Drawing.Size(315, 20);
            this.Request_In_SD.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(603, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "Очередь заявок";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(606, 349);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            // 
            // Time_Of_Work
            // 
            this.Time_Of_Work.Enabled = false;
            this.Time_Of_Work.Location = new System.Drawing.Point(497, 323);
            this.Time_Of_Work.Name = "Time_Of_Work";
            this.Time_Of_Work.Size = new System.Drawing.Size(103, 20);
            this.Time_Of_Work.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Общее время работы системы:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(314, 253);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(225, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "Внимание! Все параметры времени ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(314, 266);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(185, 13);
            this.label25.TabIndex = 31;
            this.label25.Text = "указываются в милисекундах";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(314, 300);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(174, 13);
            this.label26.TabIndex = 32;
            this.label26.Text = "Интервал до следующей заявки:";
            // 
            // Time_New_Request
            // 
            this.Time_New_Request.Enabled = false;
            this.Time_New_Request.Location = new System.Drawing.Point(497, 297);
            this.Time_New_Request.Name = "Time_New_Request";
            this.Time_New_Request.Size = new System.Drawing.Size(103, 20);
            this.Time_New_Request.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 385);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.Time_New_Request);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Time_Of_Work);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.Request_In_SD);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.requests_List);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chance_Low_Priority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Size_Queue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Request_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time_Request_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_Request_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_Request_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Time_Waiting_Request;
        private System.Windows.Forms.TextBox Time_Work_Request;
        private System.Windows.Forms.TextBox Time_Coming_Request;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Average_Time_Queue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Average_Count_Queue;
        private System.Windows.Forms.TextBox Max_Count_Queue;
        private System.Windows.Forms.TextBox Count_Queue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Wait_Time_SD;
        private System.Windows.Forms.TextBox Average_Time_SD;
        private System.Windows.Forms.TextBox Max_Time_SD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label666;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Size_Queue;
        private System.Windows.Forms.NumericUpDown Time_Request_Max;
        private System.Windows.Forms.NumericUpDown Time_Request_Min;
        private System.Windows.Forms.NumericUpDown Interval_Request_Max;
        private System.Windows.Forms.NumericUpDown Interval_Request_Min;
        private System.Windows.Forms.NumericUpDown Chance_Low_Priority;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Interval;
        private System.Windows.Forms.ListBox requests_List;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox Request_In_SD;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox Time_Of_Work;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox Time_New_Request;
    }
}

