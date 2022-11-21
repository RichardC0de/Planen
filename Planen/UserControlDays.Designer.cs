
namespace Planen
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbdays = new System.Windows.Forms.Label();
            this.lb_event = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(94, 4);
            this.lbdays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(21, 15);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // lb_event
            // 
            this.lb_event.BackColor = System.Drawing.Color.Transparent;
            this.lb_event.Location = new System.Drawing.Point(3, 39);
            this.lb_event.Name = "lb_event";
            this.lb_event.Size = new System.Drawing.Size(111, 22);
            this.lb_event.TabIndex = 1;
            this.lb_event.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_event);
            this.Controls.Add(this.lbdays);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(117, 79);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Label lb_event;
        private System.Windows.Forms.Timer timer1;
    }
}
