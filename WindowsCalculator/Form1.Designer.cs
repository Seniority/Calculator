namespace WindowsCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equation = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 48);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(258, 38);
            this.result.TabIndex = 1;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(78, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "√";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.operator_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(144, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.Text = "x²";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.operator_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(210, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.Text = "1/x";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 5;
            this.button5.TabStop = false;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button5.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(78, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 6;
            this.button6.TabStop = false;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button6.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(144, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 7;
            this.button7.TabStop = false;
            this.button7.Text = "←";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button7.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.White;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(210, 167);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(60, 60);
            this.div.TabIndex = 8;
            this.div.TabStop = false;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.operator_Click);
            this.div.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.div.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.div.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.div.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.White;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 233);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(60, 60);
            this.seven.TabIndex = 9;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.button_Click);
            this.seven.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.seven.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.seven.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.seven.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.White;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(78, 233);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(60, 60);
            this.eight.TabIndex = 10;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.button_Click);
            this.eight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.eight.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.eight.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.eight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.White;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(144, 233);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(60, 60);
            this.nine.TabIndex = 11;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.button_Click);
            this.nine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.nine.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.nine.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.nine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.White;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(210, 233);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(60, 60);
            this.mult.TabIndex = 12;
            this.mult.TabStop = false;
            this.mult.Text = "×";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.operator_Click);
            this.mult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.mult.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.mult.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.mult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.White;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 299);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(60, 60);
            this.four.TabIndex = 13;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.button_Click);
            this.four.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.four.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.four.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.four.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.White;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(78, 299);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(60, 60);
            this.five.TabIndex = 14;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button_Click);
            this.five.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.five.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.five.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.five.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.White;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(144, 299);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(60, 60);
            this.six.TabIndex = 15;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.button_Click);
            this.six.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.six.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.six.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.six.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.White;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(210, 299);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(60, 60);
            this.sub.TabIndex = 16;
            this.sub.TabStop = false;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.operator_Click);
            this.sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.sub.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.sub.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.sub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.White;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 365);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(60, 60);
            this.one.TabIndex = 17;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.button_Click);
            this.one.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.one.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.one.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.one.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.White;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(78, 365);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(60, 60);
            this.two.TabIndex = 18;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.button_Click);
            this.two.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.two.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.two.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.two.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.White;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(144, 365);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(60, 60);
            this.three.TabIndex = 19;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.button_Click);
            this.three.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.three.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.three.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.three.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(210, 365);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 60);
            this.add.TabIndex = 20;
            this.add.TabStop = false;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.operator_Click);
            this.add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.add.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.add.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.Enabled = false;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(12, 431);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 60);
            this.button21.TabIndex = 21;
            this.button21.TabStop = false;
            this.button21.Text = "+/-";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button_Click);
            this.button21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button21.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button21.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.White;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(78, 431);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(60, 60);
            this.zero.TabIndex = 22;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.button_Click);
            this.zero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.zero.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.zero.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.zero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // dec
            // 
            this.dec.BackColor = System.Drawing.Color.White;
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(144, 431);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(60, 60);
            this.dec.TabIndex = 23;
            this.dec.TabStop = false;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = false;
            this.dec.Click += new System.EventHandler(this.button_Click);
            this.dec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.dec.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.dec.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.dec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Tan;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(210, 431);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(60, 60);
            this.equal.TabIndex = 24;
            this.equal.TabStop = false;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equalButton_Click);
            this.equal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.equal.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.equal.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.equal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // equation
            // 
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.equation.Location = new System.Drawing.Point(12, 28);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(258, 17);
            this.equation.TabIndex = 2;
            this.equation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(278, 499);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.add);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.div);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

