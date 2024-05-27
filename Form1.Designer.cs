namespace Muusika_Kuulamis_Programm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_add_songs_to_list = new Button();
            btn_clear_song_list = new Button();
            btn_submit_guess = new Button();
            tb_guess_title = new TextBox();
            tb_guess_author = new TextBox();
            tb_song_list = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label_song_cleanname = new Label();
            cb_ignore_song_max_length = new CheckBox();
            tb_song_max_length = new TextBox();
            btn_play_or_pause_current_song = new Button();
            label4 = new Label();
            label5 = new Label();
            label_guess_result = new Label();
            label3 = new Label();
            btn_play_shuffle_song = new Button();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_add_songs_to_list
            // 
            btn_add_songs_to_list.Location = new Point(422, 533);
            btn_add_songs_to_list.Name = "btn_add_songs_to_list";
            btn_add_songs_to_list.Size = new Size(115, 23);
            btn_add_songs_to_list.TabIndex = 0;
            btn_add_songs_to_list.Text = "Lisa";
            btn_add_songs_to_list.UseVisualStyleBackColor = true;
            btn_add_songs_to_list.Click += btn_add_songs_to_list_Click;
            // 
            // btn_clear_song_list
            // 
            btn_clear_song_list.Location = new Point(557, 533);
            btn_clear_song_list.Name = "btn_clear_song_list";
            btn_clear_song_list.Size = new Size(115, 23);
            btn_clear_song_list.TabIndex = 1;
            btn_clear_song_list.Text = "Puhasta";
            btn_clear_song_list.UseVisualStyleBackColor = true;
            btn_clear_song_list.Click += btn_clear_song_list_Click;
            // 
            // btn_submit_guess
            // 
            btn_submit_guess.Location = new Point(226, 24);
            btn_submit_guess.Name = "btn_submit_guess";
            btn_submit_guess.Size = new Size(75, 23);
            btn_submit_guess.TabIndex = 2;
            btn_submit_guess.Text = "Kontrolli";
            btn_submit_guess.UseVisualStyleBackColor = true;
            btn_submit_guess.Click += btn_submit_guess_Click;
            // 
            // tb_guess_title
            // 
            tb_guess_title.Location = new Point(4, 24);
            tb_guess_title.Name = "tb_guess_title";
            tb_guess_title.Size = new Size(100, 23);
            tb_guess_title.TabIndex = 4;
            tb_guess_title.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_guess_author
            // 
            tb_guess_author.Location = new Point(110, 24);
            tb_guess_author.Name = "tb_guess_author";
            tb_guess_author.Size = new Size(100, 23);
            tb_guess_author.TabIndex = 5;
            tb_guess_author.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_song_list
            // 
            tb_song_list.DetectUrls = false;
            tb_song_list.Location = new Point(422, 12);
            tb_song_list.Name = "tb_song_list";
            tb_song_list.ReadOnly = true;
            tb_song_list.Size = new Size(250, 515);
            tb_song_list.TabIndex = 6;
            tb_song_list.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Barlow Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.BlanchedAlmond;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 7;
            label1.Text = "Helilooja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Barlow Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.BlanchedAlmond;
            label2.Location = new Point(110, 2);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 8;
            label2.Text = "Teose nimi";
            // 
            // label_song_cleanname
            // 
            label_song_cleanname.AutoSize = true;
            label_song_cleanname.Font = new Font("Roboto Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_song_cleanname.ForeColor = Color.IndianRed;
            label_song_cleanname.Location = new Point(151, 8);
            label_song_cleanname.Name = "label_song_cleanname";
            label_song_cleanname.Size = new Size(0, 20);
            label_song_cleanname.TabIndex = 9;
            // 
            // cb_ignore_song_max_length
            // 
            cb_ignore_song_max_length.AutoSize = true;
            cb_ignore_song_max_length.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_ignore_song_max_length.ForeColor = Color.Black;
            cb_ignore_song_max_length.Location = new Point(3, 54);
            cb_ignore_song_max_length.Name = "cb_ignore_song_max_length";
            cb_ignore_song_max_length.Size = new Size(127, 21);
            cb_ignore_song_max_length.TabIndex = 10;
            cb_ignore_song_max_length.Text = "Mängi kogu lugu";
            cb_ignore_song_max_length.UseVisualStyleBackColor = true;
            // 
            // tb_song_max_length
            // 
            tb_song_max_length.Location = new Point(3, 28);
            tb_song_max_length.Name = "tb_song_max_length";
            tb_song_max_length.Size = new Size(57, 23);
            tb_song_max_length.TabIndex = 12;
            tb_song_max_length.Text = "60";
            tb_song_max_length.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_play_or_pause_current_song
            // 
            btn_play_or_pause_current_song.Location = new Point(110, 31);
            btn_play_or_pause_current_song.Name = "btn_play_or_pause_current_song";
            btn_play_or_pause_current_song.Size = new Size(75, 23);
            btn_play_or_pause_current_song.TabIndex = 13;
            btn_play_or_pause_current_song.Text = "Peata";
            btn_play_or_pause_current_song.UseVisualStyleBackColor = true;
            btn_play_or_pause_current_song.Click += btn_play_or_pause_current_song_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(187, 17);
            label4.TabIndex = 14;
            label4.Text = "Kuulamisperiood [sekundites]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(9, 137);
            label5.Name = "label5";
            label5.Size = new Size(132, 17);
            label5.TabIndex = 15;
            label5.Text = "Markus Leppoja 11R1";
            // 
            // label_guess_result
            // 
            label_guess_result.AutoSize = true;
            label_guess_result.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_guess_result.Location = new Point(371, 27);
            label_guess_result.Name = "label_guess_result";
            label_guess_result.Size = new Size(34, 17);
            label_guess_result.TabIndex = 16;
            label_guess_result.Text = "0 / 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(307, 27);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 17;
            label3.Text = "Tulemus:";
            // 
            // btn_play_shuffle_song
            // 
            btn_play_shuffle_song.Location = new Point(4, 31);
            btn_play_shuffle_song.Name = "btn_play_shuffle_song";
            btn_play_shuffle_song.Size = new Size(100, 23);
            btn_play_shuffle_song.TabIndex = 18;
            btn_play_shuffle_song.Text = "Järgmine Teos";
            btn_play_shuffle_song.UseVisualStyleBackColor = true;
            btn_play_shuffle_song.Click += btn_play_shuffle_song_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Share", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.BlanchedAlmond;
            label6.Location = new Point(4, 10);
            label6.Name = "label6";
            label6.Size = new Size(152, 18);
            label6.TabIndex = 19;
            label6.Text = "Teose nimi ja helilooja:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(9, 10);
            label7.Name = "label7";
            label7.Size = new Size(95, 17);
            label7.TabIndex = 20;
            label7.Text = "Kasutusjuhend";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tb_song_max_length);
            panel1.Controls.Add(cb_ignore_song_max_length);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(4, 474);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 82);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label_song_cleanname);
            panel2.Controls.Add(btn_play_or_pause_current_song);
            panel2.Controls.Add(btn_play_shuffle_song);
            panel2.Location = new Point(4, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 65);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btn_submit_guess);
            panel3.Controls.Add(tb_guess_title);
            panel3.Controls.Add(tb_guess_author);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label_guess_result);
            panel3.Location = new Point(4, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 57);
            panel3.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(9, 27);
            label8.Name = "label8";
            label8.Size = new Size(334, 17);
            label8.TabIndex = 24;
            label8.Text = "1. Lae ülesse oma lemmikhitid kasutades \"Lisa\" nuppu.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(9, 44);
            label9.Name = "label9";
            label9.Size = new Size(339, 17);
            label9.TabIndex = 25;
            label9.Text = "2. Vali laulu kestvus, muutes kuulamisperioodi väärtust.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(9, 61);
            label10.Name = "label10";
            label10.Size = new Size(363, 17);
            label10.TabIndex = 26;
            label10.Text = "3. Vajuta \"Järgmine Teos\" nuppu, et kuulda helisi oma peas.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(9, 78);
            label11.Name = "label11";
            label11.Size = new Size(374, 17);
            label11.TabIndex = 27;
            label11.Text = "4. Paku teose nimi ja helilooja ning kontrolli enda tulemust.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(9, 95);
            label12.Name = "label12";
            label12.Size = new Size(361, 17);
            label12.TabIndex = 28;
            label12.Text = "5. Korda, kuni kõikide teoste autorid ja nimed sul peas on.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Share", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(9, 154);
            label13.Name = "label13";
            label13.Size = new Size(184, 17);
            label13.TabIndex = 29;
            label13.Text = "Tallinna Nõmme Gümnaasium";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(4, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(412, 177);
            panel4.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(684, 561);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tb_song_list);
            Controls.Add(btn_clear_song_list);
            Controls.Add(btn_add_songs_to_list);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Muusika Programm";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_songs_to_list;
        private Button btn_clear_song_list;
        private Button btn_submit_guess;
        private TextBox tb_guess_title;
        private TextBox tb_guess_author;
        private RichTextBox tb_song_list;
        private Label label1;
        private Label label2;
        private Label label_song_cleanname;
        private CheckBox cb_ignore_song_max_length;
        private TextBox tb_song_max_length;
        private Button btn_play_or_pause_current_song;
        private Label label4;
        private Label label5;
        private Label label_guess_result;
        private Label label3;
        private Button btn_play_shuffle_song;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel4;
    }
}
