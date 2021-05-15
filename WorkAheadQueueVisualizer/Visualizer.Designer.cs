
namespace WorkAheadQueueVisualizer
{
    partial class Visualizer
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
            this.LST_Queue = new System.Windows.Forms.ListBox();
            this.LBL_FirstEle = new System.Windows.Forms.Label();
            this.LBL_SecondEle = new System.Windows.Forms.Label();
            this.LBL_ThirdEle = new System.Windows.Forms.Label();
            this.GBX_WorkAhead = new System.Windows.Forms.GroupBox();
            this.TXT_ThirdVal = new System.Windows.Forms.TextBox();
            this.LBL_ThirdVal = new System.Windows.Forms.Label();
            this.TXT_SecondVal = new System.Windows.Forms.TextBox();
            this.LBL_SecondVal = new System.Windows.Forms.Label();
            this.TXT_FirstVal = new System.Windows.Forms.TextBox();
            this.LBL_FirstVal = new System.Windows.Forms.Label();
            this.TXT_FirstEle = new System.Windows.Forms.TextBox();
            this.TXT_SecondEle = new System.Windows.Forms.TextBox();
            this.TXT_ThirdEle = new System.Windows.Forms.TextBox();
            this.GBX_Controls = new System.Windows.Forms.GroupBox();
            this.BTN_OverWrite = new System.Windows.Forms.Button();
            this.BTN_Enqueue = new System.Windows.Forms.Button();
            this.BTN_Dequeue = new System.Windows.Forms.Button();
            this.TXT_NewEle = new System.Windows.Forms.TextBox();
            this.LBL_NewEle = new System.Windows.Forms.Label();
            this.LBL_NewVal = new System.Windows.Forms.Label();
            this.TXT_NewVal = new System.Windows.Forms.TextBox();
            this.GBX_Result = new System.Windows.Forms.GroupBox();
            this.txtDeqEle = new System.Windows.Forms.TextBox();
            this.lblDeqEle = new System.Windows.Forms.Label();
            this.lblDeqVal = new System.Windows.Forms.Label();
            this.txtDeqVal = new System.Windows.Forms.TextBox();
            this.GBX_WorkAhead.SuspendLayout();
            this.GBX_Controls.SuspendLayout();
            this.GBX_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // LST_Queue
            // 
            this.LST_Queue.FormattingEnabled = true;
            this.LST_Queue.Location = new System.Drawing.Point(12, 12);
            this.LST_Queue.Name = "LST_Queue";
            this.LST_Queue.Size = new System.Drawing.Size(354, 238);
            this.LST_Queue.TabIndex = 0;
            // 
            // LBL_FirstEle
            // 
            this.LBL_FirstEle.AutoSize = true;
            this.LBL_FirstEle.Location = new System.Drawing.Point(14, 27);
            this.LBL_FirstEle.Name = "LBL_FirstEle";
            this.LBL_FirstEle.Size = new System.Drawing.Size(65, 13);
            this.LBL_FirstEle.TabIndex = 1;
            this.LBL_FirstEle.Text = "1st Element:";
            // 
            // LBL_SecondEle
            // 
            this.LBL_SecondEle.AutoSize = true;
            this.LBL_SecondEle.Location = new System.Drawing.Point(14, 99);
            this.LBL_SecondEle.Name = "LBL_SecondEle";
            this.LBL_SecondEle.Size = new System.Drawing.Size(69, 13);
            this.LBL_SecondEle.TabIndex = 2;
            this.LBL_SecondEle.Text = "2nd Element:";
            // 
            // LBL_ThirdEle
            // 
            this.LBL_ThirdEle.AutoSize = true;
            this.LBL_ThirdEle.Location = new System.Drawing.Point(14, 175);
            this.LBL_ThirdEle.Name = "LBL_ThirdEle";
            this.LBL_ThirdEle.Size = new System.Drawing.Size(66, 13);
            this.LBL_ThirdEle.TabIndex = 3;
            this.LBL_ThirdEle.Text = "3rd Element:";
            // 
            // GBX_WorkAhead
            // 
            this.GBX_WorkAhead.Controls.Add(this.TXT_ThirdVal);
            this.GBX_WorkAhead.Controls.Add(this.LBL_ThirdVal);
            this.GBX_WorkAhead.Controls.Add(this.TXT_SecondVal);
            this.GBX_WorkAhead.Controls.Add(this.LBL_SecondVal);
            this.GBX_WorkAhead.Controls.Add(this.TXT_FirstVal);
            this.GBX_WorkAhead.Controls.Add(this.LBL_FirstVal);
            this.GBX_WorkAhead.Controls.Add(this.TXT_FirstEle);
            this.GBX_WorkAhead.Controls.Add(this.TXT_SecondEle);
            this.GBX_WorkAhead.Controls.Add(this.TXT_ThirdEle);
            this.GBX_WorkAhead.Controls.Add(this.LBL_FirstEle);
            this.GBX_WorkAhead.Controls.Add(this.LBL_ThirdEle);
            this.GBX_WorkAhead.Controls.Add(this.LBL_SecondEle);
            this.GBX_WorkAhead.Location = new System.Drawing.Point(385, 17);
            this.GBX_WorkAhead.Name = "GBX_WorkAhead";
            this.GBX_WorkAhead.Size = new System.Drawing.Size(403, 227);
            this.GBX_WorkAhead.TabIndex = 4;
            this.GBX_WorkAhead.TabStop = false;
            this.GBX_WorkAhead.Text = "Work Ahead Queue Values";
            // 
            // TXT_ThirdVal
            // 
            this.TXT_ThirdVal.Cursor = System.Windows.Forms.Cursors.No;
            this.TXT_ThirdVal.Location = new System.Drawing.Point(57, 194);
            this.TXT_ThirdVal.Name = "TXT_ThirdVal";
            this.TXT_ThirdVal.ReadOnly = true;
            this.TXT_ThirdVal.Size = new System.Drawing.Size(329, 20);
            this.TXT_ThirdVal.TabIndex = 12;
            // 
            // LBL_ThirdVal
            // 
            this.LBL_ThirdVal.AutoSize = true;
            this.LBL_ThirdVal.Location = new System.Drawing.Point(14, 197);
            this.LBL_ThirdVal.Name = "LBL_ThirdVal";
            this.LBL_ThirdVal.Size = new System.Drawing.Size(37, 13);
            this.LBL_ThirdVal.TabIndex = 11;
            this.LBL_ThirdVal.Text = "Value:";
            // 
            // TXT_SecondVal
            // 
            this.TXT_SecondVal.Cursor = System.Windows.Forms.Cursors.No;
            this.TXT_SecondVal.Location = new System.Drawing.Point(57, 118);
            this.TXT_SecondVal.Name = "TXT_SecondVal";
            this.TXT_SecondVal.ReadOnly = true;
            this.TXT_SecondVal.Size = new System.Drawing.Size(329, 20);
            this.TXT_SecondVal.TabIndex = 10;
            // 
            // LBL_SecondVal
            // 
            this.LBL_SecondVal.AutoSize = true;
            this.LBL_SecondVal.Location = new System.Drawing.Point(14, 121);
            this.LBL_SecondVal.Name = "LBL_SecondVal";
            this.LBL_SecondVal.Size = new System.Drawing.Size(37, 13);
            this.LBL_SecondVal.TabIndex = 9;
            this.LBL_SecondVal.Text = "Value:";
            // 
            // TXT_FirstVal
            // 
            this.TXT_FirstVal.Cursor = System.Windows.Forms.Cursors.No;
            this.TXT_FirstVal.Location = new System.Drawing.Point(57, 46);
            this.TXT_FirstVal.Name = "TXT_FirstVal";
            this.TXT_FirstVal.ReadOnly = true;
            this.TXT_FirstVal.Size = new System.Drawing.Size(329, 20);
            this.TXT_FirstVal.TabIndex = 8;
            // 
            // LBL_FirstVal
            // 
            this.LBL_FirstVal.AutoSize = true;
            this.LBL_FirstVal.Location = new System.Drawing.Point(14, 49);
            this.LBL_FirstVal.Name = "LBL_FirstVal";
            this.LBL_FirstVal.Size = new System.Drawing.Size(37, 13);
            this.LBL_FirstVal.TabIndex = 7;
            this.LBL_FirstVal.Text = "Value:";
            // 
            // TXT_FirstEle
            // 
            this.TXT_FirstEle.Cursor = System.Windows.Forms.Cursors.No;
            this.TXT_FirstEle.Location = new System.Drawing.Point(86, 24);
            this.TXT_FirstEle.Name = "TXT_FirstEle";
            this.TXT_FirstEle.ReadOnly = true;
            this.TXT_FirstEle.Size = new System.Drawing.Size(300, 20);
            this.TXT_FirstEle.TabIndex = 6;
            // 
            // TXT_SecondEle
            // 
            this.TXT_SecondEle.Cursor = System.Windows.Forms.Cursors.No;
            this.TXT_SecondEle.Location = new System.Drawing.Point(86, 96);
            this.TXT_SecondEle.Name = "TXT_SecondEle";
            this.TXT_SecondEle.ReadOnly = true;
            this.TXT_SecondEle.Size = new System.Drawing.Size(300, 20);
            this.TXT_SecondEle.TabIndex = 5;
            // 
            // TXT_ThirdEle
            // 
            this.TXT_ThirdEle.Cursor = System.Windows.Forms.Cursors.No;
            this.TXT_ThirdEle.Location = new System.Drawing.Point(86, 172);
            this.TXT_ThirdEle.Name = "TXT_ThirdEle";
            this.TXT_ThirdEle.ReadOnly = true;
            this.TXT_ThirdEle.Size = new System.Drawing.Size(300, 20);
            this.TXT_ThirdEle.TabIndex = 4;
            // 
            // GBX_Controls
            // 
            this.GBX_Controls.Controls.Add(this.BTN_OverWrite);
            this.GBX_Controls.Controls.Add(this.BTN_Enqueue);
            this.GBX_Controls.Controls.Add(this.BTN_Dequeue);
            this.GBX_Controls.Controls.Add(this.TXT_NewEle);
            this.GBX_Controls.Controls.Add(this.LBL_NewEle);
            this.GBX_Controls.Controls.Add(this.LBL_NewVal);
            this.GBX_Controls.Controls.Add(this.TXT_NewVal);
            this.GBX_Controls.Location = new System.Drawing.Point(12, 256);
            this.GBX_Controls.Name = "GBX_Controls";
            this.GBX_Controls.Size = new System.Drawing.Size(354, 172);
            this.GBX_Controls.TabIndex = 7;
            this.GBX_Controls.TabStop = false;
            this.GBX_Controls.Text = "Controls";
            // 
            // BTN_OverWrite
            // 
            this.BTN_OverWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_OverWrite.Location = new System.Drawing.Point(223, 108);
            this.BTN_OverWrite.Name = "BTN_OverWrite";
            this.BTN_OverWrite.Size = new System.Drawing.Size(75, 23);
            this.BTN_OverWrite.TabIndex = 26;
            this.BTN_OverWrite.Text = "Overwrite";
            this.BTN_OverWrite.UseVisualStyleBackColor = true;
            this.BTN_OverWrite.Click += new System.EventHandler(this.BTN_OverWrite_Click);
            // 
            // BTN_Enqueue
            // 
            this.BTN_Enqueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Enqueue.Location = new System.Drawing.Point(62, 108);
            this.BTN_Enqueue.Name = "BTN_Enqueue";
            this.BTN_Enqueue.Size = new System.Drawing.Size(75, 23);
            this.BTN_Enqueue.TabIndex = 25;
            this.BTN_Enqueue.Text = "Enqueue";
            this.BTN_Enqueue.UseVisualStyleBackColor = true;
            this.BTN_Enqueue.Click += new System.EventHandler(this.BTN_Enqueue_Click);
            // 
            // BTN_Dequeue
            // 
            this.BTN_Dequeue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Dequeue.Location = new System.Drawing.Point(143, 108);
            this.BTN_Dequeue.Name = "BTN_Dequeue";
            this.BTN_Dequeue.Size = new System.Drawing.Size(75, 23);
            this.BTN_Dequeue.TabIndex = 24;
            this.BTN_Dequeue.Text = "Dequeue";
            this.BTN_Dequeue.UseVisualStyleBackColor = true;
            this.BTN_Dequeue.Click += new System.EventHandler(this.BTN_Dequeue_Click);
            // 
            // TXT_NewEle
            // 
            this.TXT_NewEle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_NewEle.Location = new System.Drawing.Point(60, 46);
            this.TXT_NewEle.Name = "TXT_NewEle";
            this.TXT_NewEle.Size = new System.Drawing.Size(285, 20);
            this.TXT_NewEle.TabIndex = 20;
            // 
            // LBL_NewEle
            // 
            this.LBL_NewEle.AutoSize = true;
            this.LBL_NewEle.Location = new System.Drawing.Point(6, 49);
            this.LBL_NewEle.Name = "LBL_NewEle";
            this.LBL_NewEle.Size = new System.Drawing.Size(48, 13);
            this.LBL_NewEle.TabIndex = 19;
            this.LBL_NewEle.Text = "Element:";
            // 
            // LBL_NewVal
            // 
            this.LBL_NewVal.AutoSize = true;
            this.LBL_NewVal.Location = new System.Drawing.Point(6, 79);
            this.LBL_NewVal.Name = "LBL_NewVal";
            this.LBL_NewVal.Size = new System.Drawing.Size(37, 13);
            this.LBL_NewVal.TabIndex = 21;
            this.LBL_NewVal.Text = "Value:";
            // 
            // TXT_NewVal
            // 
            this.TXT_NewVal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_NewVal.Location = new System.Drawing.Point(49, 76);
            this.TXT_NewVal.Name = "TXT_NewVal";
            this.TXT_NewVal.Size = new System.Drawing.Size(296, 20);
            this.TXT_NewVal.TabIndex = 22;
            // 
            // GBX_Result
            // 
            this.GBX_Result.Controls.Add(this.txtDeqEle);
            this.GBX_Result.Controls.Add(this.lblDeqEle);
            this.GBX_Result.Controls.Add(this.lblDeqVal);
            this.GBX_Result.Controls.Add(this.txtDeqVal);
            this.GBX_Result.Location = new System.Drawing.Point(385, 256);
            this.GBX_Result.Name = "GBX_Result";
            this.GBX_Result.Size = new System.Drawing.Size(403, 172);
            this.GBX_Result.TabIndex = 27;
            this.GBX_Result.TabStop = false;
            this.GBX_Result.Text = "Dequeue Result";
            // 
            // txtDeqEle
            // 
            this.txtDeqEle.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDeqEle.Location = new System.Drawing.Point(136, 59);
            this.txtDeqEle.Name = "txtDeqEle";
            this.txtDeqEle.ReadOnly = true;
            this.txtDeqEle.Size = new System.Drawing.Size(238, 20);
            this.txtDeqEle.TabIndex = 20;
            // 
            // lblDeqEle
            // 
            this.lblDeqEle.AutoSize = true;
            this.lblDeqEle.Location = new System.Drawing.Point(35, 62);
            this.lblDeqEle.Name = "lblDeqEle";
            this.lblDeqEle.Size = new System.Drawing.Size(95, 13);
            this.lblDeqEle.TabIndex = 19;
            this.lblDeqEle.Text = "Dequeue Element:";
            // 
            // lblDeqVal
            // 
            this.lblDeqVal.AutoSize = true;
            this.lblDeqVal.Location = new System.Drawing.Point(35, 92);
            this.lblDeqVal.Name = "lblDeqVal";
            this.lblDeqVal.Size = new System.Drawing.Size(84, 13);
            this.lblDeqVal.TabIndex = 21;
            this.lblDeqVal.Text = "Dequeue Value:";
            // 
            // txtDeqVal
            // 
            this.txtDeqVal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDeqVal.Location = new System.Drawing.Point(125, 89);
            this.txtDeqVal.Name = "txtDeqVal";
            this.txtDeqVal.ReadOnly = true;
            this.txtDeqVal.Size = new System.Drawing.Size(249, 20);
            this.txtDeqVal.TabIndex = 22;
            // 
            // Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 438);
            this.Controls.Add(this.GBX_Result);
            this.Controls.Add(this.GBX_Controls);
            this.Controls.Add(this.GBX_WorkAhead);
            this.Controls.Add(this.LST_Queue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 477);
            this.MinimumSize = new System.Drawing.Size(815, 477);
            this.Name = "Visualizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Ahead Queue Visualizer";
            this.Load += new System.EventHandler(this.Visualizer_Load);
            this.GBX_WorkAhead.ResumeLayout(false);
            this.GBX_WorkAhead.PerformLayout();
            this.GBX_Controls.ResumeLayout(false);
            this.GBX_Controls.PerformLayout();
            this.GBX_Result.ResumeLayout(false);
            this.GBX_Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LST_Queue;
        private System.Windows.Forms.Label LBL_FirstEle;
        private System.Windows.Forms.Label LBL_SecondEle;
        private System.Windows.Forms.Label LBL_ThirdEle;
        private System.Windows.Forms.GroupBox GBX_WorkAhead;
        private System.Windows.Forms.TextBox TXT_ThirdVal;
        private System.Windows.Forms.Label LBL_ThirdVal;
        private System.Windows.Forms.TextBox TXT_SecondVal;
        private System.Windows.Forms.Label LBL_SecondVal;
        private System.Windows.Forms.TextBox TXT_FirstVal;
        private System.Windows.Forms.Label LBL_FirstVal;
        private System.Windows.Forms.TextBox TXT_FirstEle;
        private System.Windows.Forms.TextBox TXT_SecondEle;
        private System.Windows.Forms.TextBox TXT_ThirdEle;
        private System.Windows.Forms.GroupBox GBX_Controls;
        private System.Windows.Forms.Button BTN_OverWrite;
        private System.Windows.Forms.Button BTN_Enqueue;
        private System.Windows.Forms.Button BTN_Dequeue;
        private System.Windows.Forms.TextBox TXT_NewEle;
        private System.Windows.Forms.Label LBL_NewEle;
        private System.Windows.Forms.Label LBL_NewVal;
        private System.Windows.Forms.TextBox TXT_NewVal;
        private System.Windows.Forms.GroupBox GBX_Result;
        private System.Windows.Forms.TextBox txtDeqEle;
        private System.Windows.Forms.Label lblDeqEle;
        private System.Windows.Forms.Label lblDeqVal;
        private System.Windows.Forms.TextBox txtDeqVal;
    }
}

