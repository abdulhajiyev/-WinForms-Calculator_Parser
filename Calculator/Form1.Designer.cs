﻿
namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.roundCorners = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.resultPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.resultLbl = new System.Windows.Forms.Label();
            this.minBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.signsPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.equalBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.addBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.ceBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.allClrBtn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.subBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.divBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.multBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.numbersPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dotBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn3 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn0 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn6 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn9 = new Guna.UI2.WinForms.Guna2TileButton();
            this.plusMinBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.bnt2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn5 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn4 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn8 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn7 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.resultPanel.SuspendLayout();
            this.signsPanel.SuspendLayout();
            this.numbersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundCorners
            // 
            this.roundCorners.BorderRadius = 25;
            this.roundCorners.TargetControl = this;
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resultPanel.Controls.Add(this.resultLbl);
            this.resultPanel.Controls.Add(this.minBtn);
            this.resultPanel.Controls.Add(this.closeBtn);
            this.guna2Transition1.SetDecoration(this.resultPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultPanel.FillColor = System.Drawing.Color.Black;
            this.resultPanel.FillColor2 = System.Drawing.Color.Black;
            this.resultPanel.Location = new System.Drawing.Point(0, 0);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.ShadowDecoration.Parent = this.resultPanel;
            this.resultPanel.Size = new System.Drawing.Size(500, 100);
            this.resultPanel.TabIndex = 0;
            // 
            // resultLbl
            // 
            this.resultLbl.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.resultLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resultLbl.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold);
            this.resultLbl.ForeColor = System.Drawing.Color.White;
            this.resultLbl.Location = new System.Drawing.Point(100, 25);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(5, 25, 5, 25);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultLbl.Size = new System.Drawing.Size(386, 50);
            this.resultLbl.TabIndex = 1;
            this.resultLbl.Text = "0";
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.CheckedState.Parent = this.minBtn;
            this.guna2Transition1.SetDecoration(this.minBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.minBtn.HoverState.ImageSize = new System.Drawing.Size(10, 10);
            this.minBtn.HoverState.Parent = this.minBtn;
            this.minBtn.Image = global::Calculator.Properties.Resources.minimize;
            this.minBtn.ImageSize = new System.Drawing.Size(10, 10);
            this.minBtn.Location = new System.Drawing.Point(25, 10);
            this.minBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minBtn.Name = "minBtn";
            this.minBtn.PressedState.ImageSize = new System.Drawing.Size(10, 10);
            this.minBtn.PressedState.Parent = this.minBtn;
            this.minBtn.Size = new System.Drawing.Size(10, 10);
            this.minBtn.TabIndex = 0;
            this.minBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.minBtn.Click += new System.EventHandler(this.minBox_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.CheckedState.Parent = this.closeBtn;
            this.guna2Transition1.SetDecoration(this.closeBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.closeBtn.HoverState.ImageSize = new System.Drawing.Size(10, 10);
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.Image = global::Calculator.Properties.Resources.close;
            this.closeBtn.ImageSize = new System.Drawing.Size(10, 10);
            this.closeBtn.Location = new System.Drawing.Point(9, 10);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedState.ImageSize = new System.Drawing.Size(10, 10);
            this.closeBtn.PressedState.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(10, 10);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // signsPanel
            // 
            this.signsPanel.BackColor = System.Drawing.Color.Transparent;
            this.signsPanel.Controls.Add(this.equalBtn);
            this.signsPanel.Controls.Add(this.addBtn);
            this.signsPanel.Controls.Add(this.ceBtn);
            this.signsPanel.Controls.Add(this.allClrBtn);
            this.signsPanel.Controls.Add(this.subBtn);
            this.signsPanel.Controls.Add(this.divBtn);
            this.signsPanel.Controls.Add(this.multBtn);
            this.guna2Transition1.SetDecoration(this.signsPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.signsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.signsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(4)))), ((int)(((byte)(1)))));
            this.signsPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(1)))));
            this.signsPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.signsPanel.Location = new System.Drawing.Point(300, 100);
            this.signsPanel.Name = "signsPanel";
            this.signsPanel.ShadowDecoration.Parent = this.signsPanel;
            this.signsPanel.Size = new System.Drawing.Size(200, 400);
            this.signsPanel.TabIndex = 1;
            // 
            // equalBtn
            // 
            this.equalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equalBtn.Animated = true;
            this.equalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.equalBtn.CheckedState.Parent = this.equalBtn;
            this.equalBtn.CustomImages.Parent = this.equalBtn;
            this.guna2Transition1.SetDecoration(this.equalBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.equalBtn.FillColor = System.Drawing.Color.Transparent;
            this.equalBtn.Font = new System.Drawing.Font("Gotham Rounded", 15.75F, System.Drawing.FontStyle.Bold);
            this.equalBtn.ForeColor = System.Drawing.Color.White;
            this.equalBtn.HoverState.Parent = this.equalBtn;
            this.equalBtn.Location = new System.Drawing.Point(100, 200);
            this.equalBtn.Margin = new System.Windows.Forms.Padding(0);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equalBtn.ShadowDecoration.Parent = this.equalBtn;
            this.equalBtn.Size = new System.Drawing.Size(100, 200);
            this.equalBtn.TabIndex = 1;
            this.equalBtn.Tag = "=";
            this.equalBtn.Text = "=";
            this.equalBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Animated = true;
            this.addBtn.CheckedState.Parent = this.addBtn;
            this.addBtn.CustomImages.Parent = this.addBtn;
            this.guna2Transition1.SetDecoration(this.addBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addBtn.FillColor = System.Drawing.Color.White;
            this.addBtn.Font = new System.Drawing.Font("Gotham Rounded", 15.75F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.addBtn.HoverState.Parent = this.addBtn;
            this.addBtn.Location = new System.Drawing.Point(0, 0);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(100, 100);
            this.addBtn.TabIndex = 1;
            this.addBtn.Tag = "+";
            this.addBtn.Text = "+";
            this.addBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.addBtn.Click += new System.EventHandler(this.signs_Click);
            // 
            // ceBtn
            // 
            this.ceBtn.Animated = true;
            this.ceBtn.BackColor = System.Drawing.Color.Transparent;
            this.ceBtn.CheckedState.Parent = this.ceBtn;
            this.ceBtn.CustomImages.Parent = this.ceBtn;
            this.guna2Transition1.SetDecoration(this.ceBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ceBtn.FillColor = System.Drawing.Color.White;
            this.ceBtn.Font = new System.Drawing.Font("Gotham Rounded", 15.75F, System.Drawing.FontStyle.Bold);
            this.ceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.ceBtn.HoverState.Parent = this.ceBtn;
            this.ceBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.ceBtn.Location = new System.Drawing.Point(100, 100);
            this.ceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ceBtn.Name = "ceBtn";
            this.ceBtn.ShadowDecoration.Parent = this.ceBtn;
            this.ceBtn.Size = new System.Drawing.Size(100, 100);
            this.ceBtn.TabIndex = 0;
            this.ceBtn.Text = "←";
            this.ceBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ceBtn.Click += new System.EventHandler(this.ceBtn_Click);
            // 
            // allClrBtn
            // 
            this.allClrBtn.Animated = true;
            this.allClrBtn.BackColor = System.Drawing.Color.Transparent;
            this.allClrBtn.CheckedState.Parent = this.allClrBtn;
            this.allClrBtn.CustomImages.Parent = this.allClrBtn;
            this.guna2Transition1.SetDecoration(this.allClrBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.allClrBtn.FillColor = System.Drawing.Color.White;
            this.allClrBtn.FillColor2 = System.Drawing.Color.White;
            this.allClrBtn.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allClrBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.allClrBtn.HoverState.Parent = this.allClrBtn;
            this.allClrBtn.Location = new System.Drawing.Point(100, 0);
            this.allClrBtn.Margin = new System.Windows.Forms.Padding(0);
            this.allClrBtn.Name = "allClrBtn";
            this.allClrBtn.ShadowDecoration.Parent = this.allClrBtn;
            this.allClrBtn.Size = new System.Drawing.Size(100, 100);
            this.allClrBtn.TabIndex = 1;
            this.allClrBtn.Text = "AC";
            this.allClrBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.allClrBtn.Click += new System.EventHandler(this.allClrBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Animated = true;
            this.subBtn.BackColor = System.Drawing.Color.Transparent;
            this.subBtn.CheckedState.Parent = this.subBtn;
            this.subBtn.CustomImages.Parent = this.subBtn;
            this.guna2Transition1.SetDecoration(this.subBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.subBtn.FillColor = System.Drawing.Color.White;
            this.subBtn.Font = new System.Drawing.Font("Gotham Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.subBtn.HoverState.Parent = this.subBtn;
            this.subBtn.Location = new System.Drawing.Point(0, 100);
            this.subBtn.Margin = new System.Windows.Forms.Padding(0);
            this.subBtn.Name = "subBtn";
            this.subBtn.ShadowDecoration.Parent = this.subBtn;
            this.subBtn.Size = new System.Drawing.Size(100, 100);
            this.subBtn.TabIndex = 0;
            this.subBtn.Tag = "-";
            this.subBtn.Text = "-";
            this.subBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.subBtn.Click += new System.EventHandler(this.signs_Click);
            // 
            // divBtn
            // 
            this.divBtn.Animated = true;
            this.divBtn.BackColor = System.Drawing.Color.Transparent;
            this.divBtn.CheckedState.Parent = this.divBtn;
            this.divBtn.CustomImages.Parent = this.divBtn;
            this.guna2Transition1.SetDecoration(this.divBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.divBtn.FillColor = System.Drawing.Color.White;
            this.divBtn.Font = new System.Drawing.Font("Gotham Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.divBtn.HoverState.Parent = this.divBtn;
            this.divBtn.Location = new System.Drawing.Point(0, 300);
            this.divBtn.Margin = new System.Windows.Forms.Padding(0);
            this.divBtn.Name = "divBtn";
            this.divBtn.ShadowDecoration.Parent = this.divBtn;
            this.divBtn.Size = new System.Drawing.Size(100, 100);
            this.divBtn.TabIndex = 0;
            this.divBtn.Tag = "/";
            this.divBtn.Text = "÷";
            this.divBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.divBtn.Click += new System.EventHandler(this.signs_Click);
            // 
            // multBtn
            // 
            this.multBtn.Animated = true;
            this.multBtn.BackColor = System.Drawing.Color.Transparent;
            this.multBtn.CheckedState.Parent = this.multBtn;
            this.multBtn.CustomImages.Parent = this.multBtn;
            this.guna2Transition1.SetDecoration(this.multBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.multBtn.FillColor = System.Drawing.Color.White;
            this.multBtn.Font = new System.Drawing.Font("Gotham Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.multBtn.HoverState.Parent = this.multBtn;
            this.multBtn.Location = new System.Drawing.Point(0, 200);
            this.multBtn.Margin = new System.Windows.Forms.Padding(0);
            this.multBtn.Name = "multBtn";
            this.multBtn.ShadowDecoration.Parent = this.multBtn;
            this.multBtn.Size = new System.Drawing.Size(100, 100);
            this.multBtn.TabIndex = 0;
            this.multBtn.Tag = "*";
            this.multBtn.Text = "*";
            this.multBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.multBtn.Click += new System.EventHandler(this.signs_Click);
            // 
            // numbersPanel
            // 
            this.numbersPanel.Controls.Add(this.dotBtn);
            this.numbersPanel.Controls.Add(this.btn3);
            this.numbersPanel.Controls.Add(this.btn0);
            this.numbersPanel.Controls.Add(this.btn6);
            this.numbersPanel.Controls.Add(this.btn9);
            this.numbersPanel.Controls.Add(this.plusMinBtn);
            this.numbersPanel.Controls.Add(this.bnt2);
            this.numbersPanel.Controls.Add(this.btn1);
            this.numbersPanel.Controls.Add(this.btn5);
            this.numbersPanel.Controls.Add(this.btn4);
            this.numbersPanel.Controls.Add(this.btn8);
            this.numbersPanel.Controls.Add(this.btn7);
            this.guna2Transition1.SetDecoration(this.numbersPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numbersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numbersPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.numbersPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.numbersPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.numbersPanel.Location = new System.Drawing.Point(0, 100);
            this.numbersPanel.Name = "numbersPanel";
            this.numbersPanel.ShadowDecoration.Parent = this.numbersPanel;
            this.numbersPanel.Size = new System.Drawing.Size(300, 400);
            this.numbersPanel.TabIndex = 2;
            // 
            // dotBtn
            // 
            this.dotBtn.Animated = true;
            this.dotBtn.BackColor = System.Drawing.Color.Transparent;
            this.dotBtn.CheckedState.Parent = this.dotBtn;
            this.dotBtn.CustomImages.Parent = this.dotBtn;
            this.guna2Transition1.SetDecoration(this.dotBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dotBtn.FillColor = System.Drawing.Color.Transparent;
            this.dotBtn.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.ForeColor = System.Drawing.Color.White;
            this.dotBtn.HoverState.Parent = this.dotBtn;
            this.dotBtn.Location = new System.Drawing.Point(200, 300);
            this.dotBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.ShadowDecoration.Parent = this.dotBtn;
            this.dotBtn.Size = new System.Drawing.Size(100, 100);
            this.dotBtn.TabIndex = 0;
            this.dotBtn.Text = ".";
            this.dotBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.dotBtn.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn3
            // 
            this.btn3.Animated = true;
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.CheckedState.Parent = this.btn3;
            this.btn3.CustomImages.Parent = this.btn3;
            this.guna2Transition1.SetDecoration(this.btn3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn3.FillColor = System.Drawing.Color.Transparent;
            this.btn3.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.HoverState.Parent = this.btn3;
            this.btn3.Location = new System.Drawing.Point(200, 200);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.ShadowDecoration.Parent = this.btn3;
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 0;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn3.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn0
            // 
            this.btn0.Animated = true;
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.CheckedState.Parent = this.btn0;
            this.btn0.CustomImages.Parent = this.btn0;
            this.guna2Transition1.SetDecoration(this.btn0, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn0.FillColor = System.Drawing.Color.Transparent;
            this.btn0.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.HoverState.Parent = this.btn0;
            this.btn0.Location = new System.Drawing.Point(0, 300);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.ShadowDecoration.Parent = this.btn0;
            this.btn0.Size = new System.Drawing.Size(100, 100);
            this.btn0.TabIndex = 0;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn0.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn6
            // 
            this.btn6.Animated = true;
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.CheckedState.Parent = this.btn6;
            this.btn6.CustomImages.Parent = this.btn6;
            this.guna2Transition1.SetDecoration(this.btn6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn6.FillColor = System.Drawing.Color.Transparent;
            this.btn6.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.HoverState.Parent = this.btn6;
            this.btn6.Location = new System.Drawing.Point(200, 100);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.ShadowDecoration.Parent = this.btn6;
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 0;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn6.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn9
            // 
            this.btn9.Animated = true;
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.CheckedState.Parent = this.btn9;
            this.btn9.CustomImages.Parent = this.btn9;
            this.guna2Transition1.SetDecoration(this.btn9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn9.FillColor = System.Drawing.Color.Transparent;
            this.btn9.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.HoverState.Parent = this.btn9;
            this.btn9.Location = new System.Drawing.Point(200, 0);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.ShadowDecoration.Parent = this.btn9;
            this.btn9.Size = new System.Drawing.Size(100, 100);
            this.btn9.TabIndex = 0;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn9.Click += new System.EventHandler(this.btns_Click);
            // 
            // plusMinBtn
            // 
            this.plusMinBtn.Animated = true;
            this.plusMinBtn.BackColor = System.Drawing.Color.Transparent;
            this.plusMinBtn.CheckedState.Parent = this.plusMinBtn;
            this.plusMinBtn.CustomImages.Parent = this.plusMinBtn;
            this.guna2Transition1.SetDecoration(this.plusMinBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.plusMinBtn.Enabled = false;
            this.plusMinBtn.FillColor = System.Drawing.Color.Transparent;
            this.plusMinBtn.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinBtn.ForeColor = System.Drawing.Color.White;
            this.plusMinBtn.HoverState.Parent = this.plusMinBtn;
            this.plusMinBtn.Location = new System.Drawing.Point(100, 300);
            this.plusMinBtn.Margin = new System.Windows.Forms.Padding(0);
            this.plusMinBtn.Name = "plusMinBtn";
            this.plusMinBtn.ShadowDecoration.Parent = this.plusMinBtn;
            this.plusMinBtn.Size = new System.Drawing.Size(100, 100);
            this.plusMinBtn.TabIndex = 0;
            this.plusMinBtn.Text = "+/-";
            this.plusMinBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // bnt2
            // 
            this.bnt2.Animated = true;
            this.bnt2.BackColor = System.Drawing.Color.Transparent;
            this.bnt2.CheckedState.Parent = this.bnt2;
            this.bnt2.CustomImages.Parent = this.bnt2;
            this.guna2Transition1.SetDecoration(this.bnt2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bnt2.FillColor = System.Drawing.Color.Transparent;
            this.bnt2.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt2.ForeColor = System.Drawing.Color.White;
            this.bnt2.HoverState.Parent = this.bnt2;
            this.bnt2.Location = new System.Drawing.Point(100, 200);
            this.bnt2.Margin = new System.Windows.Forms.Padding(0);
            this.bnt2.Name = "bnt2";
            this.bnt2.ShadowDecoration.Parent = this.bnt2;
            this.bnt2.Size = new System.Drawing.Size(100, 100);
            this.bnt2.TabIndex = 0;
            this.bnt2.Tag = "2";
            this.bnt2.Text = "2";
            this.bnt2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.bnt2.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn1
            // 
            this.btn1.Animated = true;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.CheckedState.Parent = this.btn1;
            this.btn1.CustomImages.Parent = this.btn1;
            this.guna2Transition1.SetDecoration(this.btn1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn1.FillColor = System.Drawing.Color.Transparent;
            this.btn1.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.HoverState.Parent = this.btn1;
            this.btn1.Location = new System.Drawing.Point(0, 200);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.ShadowDecoration.Parent = this.btn1;
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn1.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn5
            // 
            this.btn5.Animated = true;
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.CheckedState.Parent = this.btn5;
            this.btn5.CustomImages.Parent = this.btn5;
            this.guna2Transition1.SetDecoration(this.btn5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn5.FillColor = System.Drawing.Color.Transparent;
            this.btn5.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.HoverState.Parent = this.btn5;
            this.btn5.Location = new System.Drawing.Point(100, 100);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.ShadowDecoration.Parent = this.btn5;
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 0;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn5.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn4
            // 
            this.btn4.Animated = true;
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.CheckedState.Parent = this.btn4;
            this.btn4.CustomImages.Parent = this.btn4;
            this.guna2Transition1.SetDecoration(this.btn4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn4.FillColor = System.Drawing.Color.Transparent;
            this.btn4.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.HoverState.Parent = this.btn4;
            this.btn4.Location = new System.Drawing.Point(0, 100);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.ShadowDecoration.Parent = this.btn4;
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 0;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn4.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn8
            // 
            this.btn8.Animated = true;
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.CheckedState.Parent = this.btn8;
            this.btn8.CustomImages.Parent = this.btn8;
            this.guna2Transition1.SetDecoration(this.btn8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn8.FillColor = System.Drawing.Color.Transparent;
            this.btn8.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.HoverState.Parent = this.btn8;
            this.btn8.Location = new System.Drawing.Point(100, 0);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.ShadowDecoration.Parent = this.btn8;
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 0;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn8.Click += new System.EventHandler(this.btns_Click);
            // 
            // btn7
            // 
            this.btn7.Animated = true;
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.CheckedState.Parent = this.btn7;
            this.btn7.CustomImages.Parent = this.btn7;
            this.guna2Transition1.SetDecoration(this.btn7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn7.FillColor = System.Drawing.Color.Transparent;
            this.btn7.Font = new System.Drawing.Font("Gotham Rounded", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.HoverState.Parent = this.btn7;
            this.btn7.Location = new System.Drawing.Point(0, 0);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.ShadowDecoration.Parent = this.btn7;
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 0;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn7.Click += new System.EventHandler(this.btns_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.guna2Transition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 1F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.numbersPanel);
            this.Controls.Add(this.signsPanel);
            this.Controls.Add(this.resultPanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.resultPanel.ResumeLayout(false);
            this.signsPanel.ResumeLayout(false);
            this.numbersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse roundCorners;
        private Guna.UI2.WinForms.Guna2GradientPanel numbersPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel signsPanel;
        private Guna.UI2.WinForms.Guna2TileButton subBtn;
        private Guna.UI2.WinForms.Guna2TileButton ceBtn;
        private Guna.UI2.WinForms.Guna2TileButton divBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel resultPanel;
        private Guna.UI2.WinForms.Guna2GradientTileButton allClrBtn;
        private Guna.UI2.WinForms.Guna2TileButton btn9;
        private Guna.UI2.WinForms.Guna2TileButton btn8;
        private Guna.UI2.WinForms.Guna2TileButton btn7;
        private Guna.UI2.WinForms.Guna2TileButton dotBtn;
        private Guna.UI2.WinForms.Guna2TileButton btn3;
        private Guna.UI2.WinForms.Guna2TileButton btn6;
        private Guna.UI2.WinForms.Guna2TileButton btn0;
        private Guna.UI2.WinForms.Guna2TileButton plusMinBtn;
        private Guna.UI2.WinForms.Guna2TileButton bnt2;
        private Guna.UI2.WinForms.Guna2TileButton btn1;
        private Guna.UI2.WinForms.Guna2TileButton btn5;
        private Guna.UI2.WinForms.Guna2TileButton btn4;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Guna.UI2.WinForms.Guna2ImageButton minBtn;
        private Guna.UI2.WinForms.Guna2TileButton multBtn;
        private System.Windows.Forms.Label resultLbl;
        private Guna.UI2.WinForms.Guna2TileButton equalBtn;
        private Guna.UI2.WinForms.Guna2TileButton addBtn;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}

