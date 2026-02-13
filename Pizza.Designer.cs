namespace PizzaProject
{
    partial class Pizza
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
            this.Header = new System.Windows.Forms.Label();
            this.Sizebox = new System.Windows.Forms.GroupBox();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMeduim = new System.Windows.Forms.RadioButton();
            this.radiosmall = new System.Windows.Forms.RadioButton();
            this.Crusttypebox = new System.Windows.Forms.GroupBox();
            this.radioThick = new System.Windows.Forms.RadioButton();
            this.radioThin = new System.Windows.Forms.RadioButton();
            this.ToppingsBox = new System.Windows.Forms.GroupBox();
            this.checkPeppers = new System.Windows.Forms.CheckBox();
            this.checkOlives = new System.Windows.Forms.CheckBox();
            this.checkOnion = new System.Windows.Forms.CheckBox();
            this.checkTomatos = new System.Windows.Forms.CheckBox();
            this.checkMushroom = new System.Windows.Forms.CheckBox();
            this.checkCheese = new System.Windows.Forms.CheckBox();
            this.wheretoeatbox = new System.Windows.Forms.GroupBox();
            this.radioTakeOut = new System.Windows.Forms.RadioButton();
            this.radioeatin = new System.Windows.Forms.RadioButton();
            this.order = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.orderSummarybox = new System.Windows.Forms.GroupBox();
            this.hash = new System.Windows.Forms.Label();
            this.PriceT = new System.Windows.Forms.Label();
            this.PriceL = new System.Windows.Forms.Label();
            this.WhereToEatT = new System.Windows.Forms.Label();
            this.wheretoeatl = new System.Windows.Forms.Label();
            this.CrustT = new System.Windows.Forms.Label();
            this.CrustTypeL = new System.Windows.Forms.Label();
            this.ToppingsT = new System.Windows.Forms.Label();
            this.ToppingsL = new System.Windows.Forms.Label();
            this.SizeT = new System.Windows.Forms.Label();
            this.SizeL = new System.Windows.Forms.Label();
            this.Sizebox.SuspendLayout();
            this.Crusttypebox.SuspendLayout();
            this.ToppingsBox.SuspendLayout();
            this.wheretoeatbox.SuspendLayout();
            this.orderSummarybox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.Red;
            this.Header.Location = new System.Drawing.Point(505, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(340, 46);
            this.Header.TabIndex = 0;
            this.Header.Text = "MAKE  YOUR PIZZA";
            // 
            // Sizebox
            // 
            this.Sizebox.Controls.Add(this.radioLarge);
            this.Sizebox.Controls.Add(this.radioMeduim);
            this.Sizebox.Controls.Add(this.radiosmall);
            this.Sizebox.Location = new System.Drawing.Point(245, 72);
            this.Sizebox.Name = "Sizebox";
            this.Sizebox.Size = new System.Drawing.Size(190, 139);
            this.Sizebox.TabIndex = 1;
            this.Sizebox.TabStop = false;
            this.Sizebox.Text = "Size";
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(6, 73);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(63, 20);
            this.radioLarge.TabIndex = 4;
            this.radioLarge.TabStop = true;
            this.radioLarge.Tag = "30";
            this.radioLarge.Text = "Large";
            this.radioLarge.UseVisualStyleBackColor = true;
            this.radioLarge.CheckedChanged += new System.EventHandler(this.radioLarge_CheckedChanged);
            // 
            // radioMeduim
            // 
            this.radioMeduim.AutoSize = true;
            this.radioMeduim.Location = new System.Drawing.Point(6, 47);
            this.radioMeduim.Name = "radioMeduim";
            this.radioMeduim.Size = new System.Drawing.Size(76, 20);
            this.radioMeduim.TabIndex = 3;
            this.radioMeduim.TabStop = true;
            this.radioMeduim.Tag = "20";
            this.radioMeduim.Text = "Meduim";
            this.radioMeduim.UseVisualStyleBackColor = true;
            this.radioMeduim.CheckedChanged += new System.EventHandler(this.radioMeduim_CheckedChanged);
            // 
            // radiosmall
            // 
            this.radiosmall.AutoSize = true;
            this.radiosmall.Location = new System.Drawing.Point(6, 21);
            this.radiosmall.Name = "radiosmall";
            this.radiosmall.Size = new System.Drawing.Size(62, 20);
            this.radiosmall.TabIndex = 2;
            this.radiosmall.TabStop = true;
            this.radiosmall.Tag = "10";
            this.radiosmall.Text = "Small";
            this.radiosmall.UseVisualStyleBackColor = true;
            this.radiosmall.CheckedChanged += new System.EventHandler(this.radiosmall_CheckedChanged);
            // 
            // Crusttypebox
            // 
            this.Crusttypebox.Controls.Add(this.radioThick);
            this.Crusttypebox.Controls.Add(this.radioThin);
            this.Crusttypebox.Location = new System.Drawing.Point(245, 234);
            this.Crusttypebox.Name = "Crusttypebox";
            this.Crusttypebox.Size = new System.Drawing.Size(190, 139);
            this.Crusttypebox.TabIndex = 2;
            this.Crusttypebox.TabStop = false;
            this.Crusttypebox.Text = "Crust Type";
            // 
            // radioThick
            // 
            this.radioThick.AutoSize = true;
            this.radioThick.Location = new System.Drawing.Point(6, 47);
            this.radioThick.Name = "radioThick";
            this.radioThick.Size = new System.Drawing.Size(92, 20);
            this.radioThick.TabIndex = 3;
            this.radioThick.TabStop = true;
            this.radioThick.Tag = "20";
            this.radioThick.Text = "Thick crust";
            this.radioThick.UseVisualStyleBackColor = true;
            this.radioThick.CheckedChanged += new System.EventHandler(this.radioThick_CheckedChanged);
            // 
            // radioThin
            // 
            this.radioThin.AutoSize = true;
            this.radioThin.Location = new System.Drawing.Point(7, 21);
            this.radioThin.Name = "radioThin";
            this.radioThin.Size = new System.Drawing.Size(85, 20);
            this.radioThin.TabIndex = 2;
            this.radioThin.TabStop = true;
            this.radioThin.Tag = "10";
            this.radioThin.Text = "Thin crust";
            this.radioThin.UseVisualStyleBackColor = true;
            this.radioThin.CheckedChanged += new System.EventHandler(this.radioThin_CheckedChanged);
            // 
            // ToppingsBox
            // 
            this.ToppingsBox.Controls.Add(this.checkPeppers);
            this.ToppingsBox.Controls.Add(this.checkOlives);
            this.ToppingsBox.Controls.Add(this.checkOnion);
            this.ToppingsBox.Controls.Add(this.checkTomatos);
            this.ToppingsBox.Controls.Add(this.checkMushroom);
            this.ToppingsBox.Controls.Add(this.checkCheese);
            this.ToppingsBox.Location = new System.Drawing.Point(548, 93);
            this.ToppingsBox.Name = "ToppingsBox";
            this.ToppingsBox.Size = new System.Drawing.Size(279, 139);
            this.ToppingsBox.TabIndex = 3;
            this.ToppingsBox.TabStop = false;
            this.ToppingsBox.Text = "Toppings";
            // 
            // checkPeppers
            // 
            this.checkPeppers.AutoSize = true;
            this.checkPeppers.Location = new System.Drawing.Point(147, 73);
            this.checkPeppers.Name = "checkPeppers";
            this.checkPeppers.Size = new System.Drawing.Size(121, 20);
            this.checkPeppers.TabIndex = 5;
            this.checkPeppers.Tag = "5";
            this.checkPeppers.Text = "Green Peppers";
            this.checkPeppers.UseVisualStyleBackColor = true;
            this.checkPeppers.CheckedChanged += new System.EventHandler(this.checkPeppers_CheckedChanged);
            // 
            // checkOlives
            // 
            this.checkOlives.AutoSize = true;
            this.checkOlives.Location = new System.Drawing.Point(147, 49);
            this.checkOlives.Name = "checkOlives";
            this.checkOlives.Size = new System.Drawing.Size(67, 20);
            this.checkOlives.TabIndex = 4;
            this.checkOlives.Tag = "5";
            this.checkOlives.Text = "Olives";
            this.checkOlives.UseVisualStyleBackColor = true;
            this.checkOlives.CheckedChanged += new System.EventHandler(this.checkOlives_CheckedChanged);
            // 
            // checkOnion
            // 
            this.checkOnion.AutoSize = true;
            this.checkOnion.Location = new System.Drawing.Point(147, 22);
            this.checkOnion.Name = "checkOnion";
            this.checkOnion.Size = new System.Drawing.Size(64, 20);
            this.checkOnion.TabIndex = 3;
            this.checkOnion.Tag = "5";
            this.checkOnion.Text = "Onion";
            this.checkOnion.UseVisualStyleBackColor = true;
            this.checkOnion.CheckedChanged += new System.EventHandler(this.checkOnion_CheckedChanged);
            // 
            // checkTomatos
            // 
            this.checkTomatos.AutoSize = true;
            this.checkTomatos.Location = new System.Drawing.Point(7, 73);
            this.checkTomatos.Name = "checkTomatos";
            this.checkTomatos.Size = new System.Drawing.Size(83, 20);
            this.checkTomatos.TabIndex = 2;
            this.checkTomatos.Tag = "5";
            this.checkTomatos.Text = "Tomatos";
            this.checkTomatos.UseVisualStyleBackColor = true;
            this.checkTomatos.CheckedChanged += new System.EventHandler(this.checkTomatos_CheckedChanged);
            // 
            // checkMushroom
            // 
            this.checkMushroom.AutoSize = true;
            this.checkMushroom.Location = new System.Drawing.Point(7, 48);
            this.checkMushroom.Name = "checkMushroom";
            this.checkMushroom.Size = new System.Drawing.Size(92, 20);
            this.checkMushroom.TabIndex = 1;
            this.checkMushroom.Tag = "5";
            this.checkMushroom.Text = "Mushroom";
            this.checkMushroom.UseVisualStyleBackColor = true;
            this.checkMushroom.CheckedChanged += new System.EventHandler(this.checkMushroom_CheckedChanged);
            // 
            // checkCheese
            // 
            this.checkCheese.AutoSize = true;
            this.checkCheese.Location = new System.Drawing.Point(7, 22);
            this.checkCheese.Name = "checkCheese";
            this.checkCheese.Size = new System.Drawing.Size(109, 20);
            this.checkCheese.TabIndex = 0;
            this.checkCheese.Tag = "5";
            this.checkCheese.Text = "Extra Cheese";
            this.checkCheese.UseVisualStyleBackColor = true;
            this.checkCheese.CheckedChanged += new System.EventHandler(this.checkExtraCheese_CheckedChanged);
            // 
            // wheretoeatbox
            // 
            this.wheretoeatbox.Controls.Add(this.radioTakeOut);
            this.wheretoeatbox.Controls.Add(this.radioeatin);
            this.wheretoeatbox.Location = new System.Drawing.Point(572, 255);
            this.wheretoeatbox.Name = "wheretoeatbox";
            this.wheretoeatbox.Size = new System.Drawing.Size(244, 52);
            this.wheretoeatbox.TabIndex = 4;
            this.wheretoeatbox.TabStop = false;
            this.wheretoeatbox.Text = "Where To Eat";
            // 
            // radioTakeOut
            // 
            this.radioTakeOut.AutoSize = true;
            this.radioTakeOut.Location = new System.Drawing.Point(102, 21);
            this.radioTakeOut.Name = "radioTakeOut";
            this.radioTakeOut.Size = new System.Drawing.Size(83, 20);
            this.radioTakeOut.TabIndex = 3;
            this.radioTakeOut.TabStop = true;
            this.radioTakeOut.Text = "Take Out";
            this.radioTakeOut.UseVisualStyleBackColor = true;
            this.radioTakeOut.CheckedChanged += new System.EventHandler(this.radioTakeOut_CheckedChanged);
            // 
            // radioeatin
            // 
            this.radioeatin.AutoSize = true;
            this.radioeatin.Location = new System.Drawing.Point(6, 21);
            this.radioeatin.Name = "radioeatin";
            this.radioeatin.Size = new System.Drawing.Size(61, 20);
            this.radioeatin.TabIndex = 2;
            this.radioeatin.TabStop = true;
            this.radioeatin.Text = "Eat In";
            this.radioeatin.UseVisualStyleBackColor = true;
            this.radioeatin.CheckedChanged += new System.EventHandler(this.radioeatin_CheckedChanged);
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(578, 332);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(112, 23);
            this.order.TabIndex = 5;
            this.order.Text = "Order Pizza";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(715, 332);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(112, 23);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset Form";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // orderSummarybox
            // 
            this.orderSummarybox.Controls.Add(this.hash);
            this.orderSummarybox.Controls.Add(this.PriceT);
            this.orderSummarybox.Controls.Add(this.PriceL);
            this.orderSummarybox.Controls.Add(this.WhereToEatT);
            this.orderSummarybox.Controls.Add(this.wheretoeatl);
            this.orderSummarybox.Controls.Add(this.CrustT);
            this.orderSummarybox.Controls.Add(this.CrustTypeL);
            this.orderSummarybox.Controls.Add(this.ToppingsT);
            this.orderSummarybox.Controls.Add(this.ToppingsL);
            this.orderSummarybox.Controls.Add(this.SizeT);
            this.orderSummarybox.Controls.Add(this.SizeL);
            this.orderSummarybox.Location = new System.Drawing.Point(907, 72);
            this.orderSummarybox.Name = "orderSummarybox";
            this.orderSummarybox.Size = new System.Drawing.Size(252, 301);
            this.orderSummarybox.TabIndex = 7;
            this.orderSummarybox.TabStop = false;
            this.orderSummarybox.Text = "Order Summary";
            // 
            // hash
            // 
            this.hash.AutoSize = true;
            this.hash.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hash.ForeColor = System.Drawing.Color.LimeGreen;
            this.hash.Location = new System.Drawing.Point(21, 229);
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(44, 46);
            this.hash.TabIndex = 10;
            this.hash.Text = "$";
            // 
            // PriceT
            // 
            this.PriceT.AutoSize = true;
            this.PriceT.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceT.ForeColor = System.Drawing.Color.LimeGreen;
            this.PriceT.Location = new System.Drawing.Point(57, 229);
            this.PriceT.Name = "PriceT";
            this.PriceT.Size = new System.Drawing.Size(45, 46);
            this.PriceT.TabIndex = 9;
            this.PriceT.Text = "0";
            // 
            // PriceL
            // 
            this.PriceL.AutoSize = true;
            this.PriceL.Location = new System.Drawing.Point(6, 213);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(78, 16);
            this.PriceL.TabIndex = 8;
            this.PriceL.Text = "Total Price :";
            // 
            // WhereToEatT
            // 
            this.WhereToEatT.AutoSize = true;
            this.WhereToEatT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WhereToEatT.Location = new System.Drawing.Point(108, 174);
            this.WhereToEatT.Name = "WhereToEatT";
            this.WhereToEatT.Size = new System.Drawing.Size(10, 16);
            this.WhereToEatT.TabIndex = 7;
            this.WhereToEatT.Text = ".";
            // 
            // wheretoeatl
            // 
            this.wheretoeatl.AutoSize = true;
            this.wheretoeatl.Location = new System.Drawing.Point(6, 174);
            this.wheretoeatl.Name = "wheretoeatl";
            this.wheretoeatl.Size = new System.Drawing.Size(96, 16);
            this.wheretoeatl.TabIndex = 6;
            this.wheretoeatl.Text = "Where To Eat :";
            // 
            // CrustT
            // 
            this.CrustT.AutoSize = true;
            this.CrustT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CrustT.Location = new System.Drawing.Point(90, 144);
            this.CrustT.Name = "CrustT";
            this.CrustT.Size = new System.Drawing.Size(61, 16);
            this.CrustT.TabIndex = 5;
            this.CrustT.Text = "No  Crust";
            // 
            // CrustTypeL
            // 
            this.CrustTypeL.AutoSize = true;
            this.CrustTypeL.Location = new System.Drawing.Point(6, 144);
            this.CrustTypeL.Name = "CrustTypeL";
            this.CrustTypeL.Size = new System.Drawing.Size(78, 16);
            this.CrustTypeL.TabIndex = 4;
            this.CrustTypeL.Text = "Crust Type :";
            // 
            // ToppingsT
            // 
            this.ToppingsT.AutoSize = true;
            this.ToppingsT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToppingsT.Location = new System.Drawing.Point(6, 75);
            this.ToppingsT.Name = "ToppingsT";
            this.ToppingsT.Size = new System.Drawing.Size(86, 16);
            this.ToppingsT.TabIndex = 3;
            this.ToppingsT.Text = "No Toppings";
            // 
            // ToppingsL
            // 
            this.ToppingsL.AutoSize = true;
            this.ToppingsL.Location = new System.Drawing.Point(16, 51);
            this.ToppingsL.Name = "ToppingsL";
            this.ToppingsL.Size = new System.Drawing.Size(68, 16);
            this.ToppingsL.TabIndex = 2;
            this.ToppingsL.Text = "Toppings:";
            // 
            // SizeT
            // 
            this.SizeT.AutoSize = true;
            this.SizeT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SizeT.Location = new System.Drawing.Point(66, 23);
            this.SizeT.Name = "SizeT";
            this.SizeT.Size = new System.Drawing.Size(0, 16);
            this.SizeT.TabIndex = 1;
            // 
            // SizeL
            // 
            this.SizeL.AutoSize = true;
            this.SizeL.Location = new System.Drawing.Point(21, 22);
            this.SizeL.Name = "SizeL";
            this.SizeL.Size = new System.Drawing.Size(39, 16);
            this.SizeL.TabIndex = 0;
            this.SizeL.Text = "Size :";
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaProject.Properties.Resources.slice_of_pizza_falling_into_the_air_on_a_dark_background_photo;
            this.ClientSize = new System.Drawing.Size(1406, 727);
            this.Controls.Add(this.orderSummarybox);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.order);
            this.Controls.Add(this.wheretoeatbox);
            this.Controls.Add(this.ToppingsBox);
            this.Controls.Add(this.Crusttypebox);
            this.Controls.Add(this.Sizebox);
            this.Controls.Add(this.Header);
            this.Name = "Pizza";
            this.Text = "Pizza";
            this.Sizebox.ResumeLayout(false);
            this.Sizebox.PerformLayout();
            this.Crusttypebox.ResumeLayout(false);
            this.Crusttypebox.PerformLayout();
            this.ToppingsBox.ResumeLayout(false);
            this.ToppingsBox.PerformLayout();
            this.wheretoeatbox.ResumeLayout(false);
            this.wheretoeatbox.PerformLayout();
            this.orderSummarybox.ResumeLayout(false);
            this.orderSummarybox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.GroupBox Sizebox;
        private System.Windows.Forms.RadioButton radiosmall;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.RadioButton radioMeduim;
        private System.Windows.Forms.GroupBox Crusttypebox;
        private System.Windows.Forms.RadioButton radioThick;
        private System.Windows.Forms.RadioButton radioThin;
        private System.Windows.Forms.GroupBox ToppingsBox;
        private System.Windows.Forms.CheckBox checkPeppers;
        private System.Windows.Forms.CheckBox checkOlives;
        private System.Windows.Forms.CheckBox checkOnion;
        private System.Windows.Forms.CheckBox checkTomatos;
        private System.Windows.Forms.CheckBox checkMushroom;
        private System.Windows.Forms.CheckBox checkCheese;
        private System.Windows.Forms.GroupBox wheretoeatbox;
        private System.Windows.Forms.RadioButton radioTakeOut;
        private System.Windows.Forms.RadioButton radioeatin;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.GroupBox orderSummarybox;
        private System.Windows.Forms.Label SizeL;
        private System.Windows.Forms.Label CrustTypeL;
        private System.Windows.Forms.Label ToppingsT;
        private System.Windows.Forms.Label ToppingsL;
        private System.Windows.Forms.Label SizeT;
        private System.Windows.Forms.Label PriceT;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.Label WhereToEatT;
        private System.Windows.Forms.Label wheretoeatl;
        private System.Windows.Forms.Label CrustT;
        private System.Windows.Forms.Label hash;
    }
}