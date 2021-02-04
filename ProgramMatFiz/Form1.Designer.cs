
namespace ProgramMatFiz
{
    partial class Form1
    {

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.help_vectors = new System.Windows.Forms.Button();
            this.clear1 = new System.Windows.Forms.Button();
            this.calc1 = new System.Windows.Forms.Button();
            this.alpha_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctg_box = new System.Windows.Forms.TextBox();
            this.tg_box = new System.Windows.Forms.TextBox();
            this.cos_box = new System.Windows.Forms.TextBox();
            this.sin_box = new System.Windows.Forms.TextBox();
            this.ctg_label = new System.Windows.Forms.Label();
            this.tg_label = new System.Windows.Forms.Label();
            this.cos_label = new System.Windows.Forms.Label();
            this.sin_label = new System.Windows.Forms.Label();
            this.v0_box = new System.Windows.Forms.TextBox();
            this.vy_box = new System.Windows.Forms.TextBox();
            this.vx_box = new System.Windows.Forms.TextBox();
            this.v0 = new System.Windows.Forms.Label();
            this.vy = new System.Windows.Forms.Label();
            this.vx = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.help_trig = new System.Windows.Forms.Button();
            this.clear_trig = new System.Windows.Forms.Button();
            this.angle_unit_selector = new System.Windows.Forms.ComboBox();
            this.solve_trig = new System.Windows.Forms.Button();
            this.alpha_box_trig = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctg_box_trig = new System.Windows.Forms.TextBox();
            this.tg_box_trig = new System.Windows.Forms.TextBox();
            this.cos_box_trig = new System.Windows.Forms.TextBox();
            this.sin_box_trig = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rownanie_kwadratowe = new System.Windows.Forms.TabPage();
            this.help_quadratic = new System.Windows.Forms.Button();
            this.clear_quadratic = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.quad_result = new System.Windows.Forms.TextBox();
            this.solve_quadratic = new System.Windows.Forms.Button();
            this.quad_c = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.quad_b = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.quad_a = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.działaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obliczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obliczToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.czyśćToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.rownanie_kwadratowe.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.rownanie_kwadratowe);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 287);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.help_vectors);
            this.tabPage1.Controls.Add(this.clear1);
            this.tabPage1.Controls.Add(this.calc1);
            this.tabPage1.Controls.Add(this.alpha_box);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ctg_box);
            this.tabPage1.Controls.Add(this.tg_box);
            this.tabPage1.Controls.Add(this.cos_box);
            this.tabPage1.Controls.Add(this.sin_box);
            this.tabPage1.Controls.Add(this.ctg_label);
            this.tabPage1.Controls.Add(this.tg_label);
            this.tabPage1.Controls.Add(this.cos_label);
            this.tabPage1.Controls.Add(this.sin_label);
            this.tabPage1.Controls.Add(this.v0_box);
            this.tabPage1.Controls.Add(this.vy_box);
            this.tabPage1.Controls.Add(this.vx_box);
            this.tabPage1.Controls.Add(this.v0);
            this.tabPage1.Controls.Add(this.vy);
            this.tabPage1.Controls.Add(this.vx);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wektory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(339, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "°";
            // 
            // help_vectors
            // 
            this.help_vectors.Location = new System.Drawing.Point(404, 222);
            this.help_vectors.Name = "help_vectors";
            this.help_vectors.Size = new System.Drawing.Size(75, 23);
            this.help_vectors.TabIndex = 18;
            this.help_vectors.Text = "Pomoc";
            this.help_vectors.UseVisualStyleBackColor = true;
            this.help_vectors.Click += new System.EventHandler(this.help_vectors_Click);
            // 
            // clear1
            // 
            this.clear1.Location = new System.Drawing.Point(258, 222);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(75, 23);
            this.clear1.TabIndex = 17;
            this.clear1.Text = "Czyść";
            this.clear1.UseVisualStyleBackColor = true;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // calc1
            // 
            this.calc1.Location = new System.Drawing.Point(99, 222);
            this.calc1.Name = "calc1";
            this.calc1.Size = new System.Drawing.Size(75, 23);
            this.calc1.TabIndex = 16;
            this.calc1.Text = "Oblicz";
            this.calc1.UseVisualStyleBackColor = true;
            this.calc1.Click += new System.EventHandler(this.calc1_Click);
            // 
            // alpha_box
            // 
            this.alpha_box.Location = new System.Drawing.Point(233, 178);
            this.alpha_box.Name = "alpha_box";
            this.alpha_box.Size = new System.Drawing.Size(100, 20);
            this.alpha_box.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "𝛼";
            // 
            // ctg_box
            // 
            this.ctg_box.Location = new System.Drawing.Point(418, 123);
            this.ctg_box.Name = "ctg_box";
            this.ctg_box.Size = new System.Drawing.Size(100, 20);
            this.ctg_box.TabIndex = 13;
            // 
            // tg_box
            // 
            this.tg_box.Location = new System.Drawing.Point(418, 93);
            this.tg_box.Name = "tg_box";
            this.tg_box.Size = new System.Drawing.Size(100, 20);
            this.tg_box.TabIndex = 12;
            // 
            // cos_box
            // 
            this.cos_box.Location = new System.Drawing.Point(418, 61);
            this.cos_box.Name = "cos_box";
            this.cos_box.Size = new System.Drawing.Size(100, 20);
            this.cos_box.TabIndex = 11;
            // 
            // sin_box
            // 
            this.sin_box.Location = new System.Drawing.Point(418, 30);
            this.sin_box.Name = "sin_box";
            this.sin_box.Size = new System.Drawing.Size(100, 20);
            this.sin_box.TabIndex = 10;
            // 
            // ctg_label
            // 
            this.ctg_label.AutoSize = true;
            this.ctg_label.Location = new System.Drawing.Point(356, 123);
            this.ctg_label.Name = "ctg_label";
            this.ctg_label.Size = new System.Drawing.Size(29, 13);
            this.ctg_label.TabIndex = 9;
            this.ctg_label.Text = "ctg𝛼";
            // 
            // tg_label
            // 
            this.tg_label.AutoSize = true;
            this.tg_label.Location = new System.Drawing.Point(356, 93);
            this.tg_label.Name = "tg_label";
            this.tg_label.Size = new System.Drawing.Size(23, 13);
            this.tg_label.TabIndex = 8;
            this.tg_label.Text = "tg𝛼";
            // 
            // cos_label
            // 
            this.cos_label.AutoSize = true;
            this.cos_label.Location = new System.Drawing.Point(356, 61);
            this.cos_label.Name = "cos_label";
            this.cos_label.Size = new System.Drawing.Size(31, 13);
            this.cos_label.TabIndex = 7;
            this.cos_label.Text = "cos𝛼";
            // 
            // sin_label
            // 
            this.sin_label.AutoSize = true;
            this.sin_label.Location = new System.Drawing.Point(356, 30);
            this.sin_label.Name = "sin_label";
            this.sin_label.Size = new System.Drawing.Size(27, 13);
            this.sin_label.TabIndex = 6;
            this.sin_label.Text = "sin𝛼";
            // 
            // v0_box
            // 
            this.v0_box.Location = new System.Drawing.Point(99, 123);
            this.v0_box.Name = "v0_box";
            this.v0_box.Size = new System.Drawing.Size(100, 20);
            this.v0_box.TabIndex = 5;
            // 
            // vy_box
            // 
            this.vy_box.Location = new System.Drawing.Point(99, 78);
            this.vy_box.Name = "vy_box";
            this.vy_box.Size = new System.Drawing.Size(100, 20);
            this.vy_box.TabIndex = 4;
            // 
            // vx_box
            // 
            this.vx_box.Location = new System.Drawing.Point(99, 34);
            this.vx_box.Name = "vx_box";
            this.vx_box.Size = new System.Drawing.Size(100, 20);
            this.vx_box.TabIndex = 3;
            // 
            // v0
            // 
            this.v0.AutoSize = true;
            this.v0.Location = new System.Drawing.Point(31, 123);
            this.v0.Name = "v0";
            this.v0.Size = new System.Drawing.Size(20, 13);
            this.v0.TabIndex = 2;
            this.v0.Text = "V0";
            // 
            // vy
            // 
            this.vy.AutoSize = true;
            this.vy.Location = new System.Drawing.Point(32, 78);
            this.vy.Name = "vy";
            this.vy.Size = new System.Drawing.Size(19, 13);
            this.vy.TabIndex = 1;
            this.vy.Text = "Vy";
            // 
            // vx
            // 
            this.vx.AutoSize = true;
            this.vx.Location = new System.Drawing.Point(32, 34);
            this.vx.Name = "vx";
            this.vx.Size = new System.Drawing.Size(19, 13);
            this.vx.TabIndex = 0;
            this.vx.Text = "Vx";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.help_trig);
            this.tabPage2.Controls.Add(this.clear_trig);
            this.tabPage2.Controls.Add(this.angle_unit_selector);
            this.tabPage2.Controls.Add(this.solve_trig);
            this.tabPage2.Controls.Add(this.alpha_box_trig);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.ctg_box_trig);
            this.tabPage2.Controls.Add(this.tg_box_trig);
            this.tabPage2.Controls.Add(this.cos_box_trig);
            this.tabPage2.Controls.Add(this.sin_box_trig);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trygonometria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // help_trig
            // 
            this.help_trig.Location = new System.Drawing.Point(392, 202);
            this.help_trig.Name = "help_trig";
            this.help_trig.Size = new System.Drawing.Size(75, 23);
            this.help_trig.TabIndex = 28;
            this.help_trig.Text = "Pomoc";
            this.help_trig.UseVisualStyleBackColor = true;
            this.help_trig.Click += new System.EventHandler(this.help_trig_Click);
            // 
            // clear_trig
            // 
            this.clear_trig.Location = new System.Drawing.Point(240, 202);
            this.clear_trig.Name = "clear_trig";
            this.clear_trig.Size = new System.Drawing.Size(75, 23);
            this.clear_trig.TabIndex = 27;
            this.clear_trig.Text = "Czyść";
            this.clear_trig.UseVisualStyleBackColor = true;
            this.clear_trig.Click += new System.EventHandler(this.clear_trig_Click);
            // 
            // angle_unit_selector
            // 
            this.angle_unit_selector.FormattingEnabled = true;
            this.angle_unit_selector.Items.AddRange(new object[] {
            "°",
            "rad"});
            this.angle_unit_selector.Location = new System.Drawing.Point(166, 105);
            this.angle_unit_selector.Name = "angle_unit_selector";
            this.angle_unit_selector.Size = new System.Drawing.Size(41, 21);
            this.angle_unit_selector.TabIndex = 26;
            this.angle_unit_selector.SelectedIndexChanged += new System.EventHandler(this.angle_unit_selector_SelectedIndexChanged);
            // 
            // solve_trig
            // 
            this.solve_trig.Location = new System.Drawing.Point(98, 202);
            this.solve_trig.Name = "solve_trig";
            this.solve_trig.Size = new System.Drawing.Size(75, 23);
            this.solve_trig.TabIndex = 25;
            this.solve_trig.Text = "Oblicz";
            this.solve_trig.UseVisualStyleBackColor = true;
            this.solve_trig.Click += new System.EventHandler(this.solve_trig_Click);
            // 
            // alpha_box_trig
            // 
            this.alpha_box_trig.Location = new System.Drawing.Point(60, 106);
            this.alpha_box_trig.Name = "alpha_box_trig";
            this.alpha_box_trig.Size = new System.Drawing.Size(100, 20);
            this.alpha_box_trig.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "𝛼";
            // 
            // ctg_box_trig
            // 
            this.ctg_box_trig.Location = new System.Drawing.Point(374, 139);
            this.ctg_box_trig.Name = "ctg_box_trig";
            this.ctg_box_trig.Size = new System.Drawing.Size(174, 20);
            this.ctg_box_trig.TabIndex = 21;
            // 
            // tg_box_trig
            // 
            this.tg_box_trig.Location = new System.Drawing.Point(374, 109);
            this.tg_box_trig.Name = "tg_box_trig";
            this.tg_box_trig.Size = new System.Drawing.Size(174, 20);
            this.tg_box_trig.TabIndex = 20;
            // 
            // cos_box_trig
            // 
            this.cos_box_trig.Location = new System.Drawing.Point(374, 77);
            this.cos_box_trig.Name = "cos_box_trig";
            this.cos_box_trig.Size = new System.Drawing.Size(174, 20);
            this.cos_box_trig.TabIndex = 19;
            // 
            // sin_box_trig
            // 
            this.sin_box_trig.Location = new System.Drawing.Point(374, 46);
            this.sin_box_trig.Name = "sin_box_trig";
            this.sin_box_trig.Size = new System.Drawing.Size(174, 20);
            this.sin_box_trig.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ctg𝛼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "tg𝛼";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "cos𝛼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "sin𝛼";
            // 
            // rownanie_kwadratowe
            // 
            this.rownanie_kwadratowe.Controls.Add(this.help_quadratic);
            this.rownanie_kwadratowe.Controls.Add(this.clear_quadratic);
            this.rownanie_kwadratowe.Controls.Add(this.label12);
            this.rownanie_kwadratowe.Controls.Add(this.quad_result);
            this.rownanie_kwadratowe.Controls.Add(this.solve_quadratic);
            this.rownanie_kwadratowe.Controls.Add(this.quad_c);
            this.rownanie_kwadratowe.Controls.Add(this.label11);
            this.rownanie_kwadratowe.Controls.Add(this.quad_b);
            this.rownanie_kwadratowe.Controls.Add(this.label10);
            this.rownanie_kwadratowe.Controls.Add(this.quad_a);
            this.rownanie_kwadratowe.Controls.Add(this.label9);
            this.rownanie_kwadratowe.Controls.Add(this.label7);
            this.rownanie_kwadratowe.Location = new System.Drawing.Point(4, 22);
            this.rownanie_kwadratowe.Name = "rownanie_kwadratowe";
            this.rownanie_kwadratowe.Padding = new System.Windows.Forms.Padding(3);
            this.rownanie_kwadratowe.Size = new System.Drawing.Size(574, 261);
            this.rownanie_kwadratowe.TabIndex = 2;
            this.rownanie_kwadratowe.Text = "Równanie kwadratowe";
            this.rownanie_kwadratowe.UseVisualStyleBackColor = true;
            // 
            // help_quadratic
            // 
            this.help_quadratic.Location = new System.Drawing.Point(418, 187);
            this.help_quadratic.Name = "help_quadratic";
            this.help_quadratic.Size = new System.Drawing.Size(75, 23);
            this.help_quadratic.TabIndex = 11;
            this.help_quadratic.Text = "Pomoc";
            this.help_quadratic.UseVisualStyleBackColor = true;
            this.help_quadratic.Click += new System.EventHandler(this.help_quadratic_Click);
            // 
            // clear_quadratic
            // 
            this.clear_quadratic.Location = new System.Drawing.Point(252, 187);
            this.clear_quadratic.Name = "clear_quadratic";
            this.clear_quadratic.Size = new System.Drawing.Size(75, 23);
            this.clear_quadratic.TabIndex = 10;
            this.clear_quadratic.Text = "Czyść";
            this.clear_quadratic.UseVisualStyleBackColor = true;
            this.clear_quadratic.Click += new System.EventHandler(this.clear_quadratic_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Wyniki";
            // 
            // quad_result
            // 
            this.quad_result.Location = new System.Drawing.Point(35, 170);
            this.quad_result.Multiline = true;
            this.quad_result.Name = "quad_result";
            this.quad_result.ReadOnly = true;
            this.quad_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.quad_result.Size = new System.Drawing.Size(186, 70);
            this.quad_result.TabIndex = 8;
            this.quad_result.Enter += new System.EventHandler(this.quad_result_Enter);
            // 
            // solve_quadratic
            // 
            this.solve_quadratic.Location = new System.Drawing.Point(239, 118);
            this.solve_quadratic.Name = "solve_quadratic";
            this.solve_quadratic.Size = new System.Drawing.Size(75, 23);
            this.solve_quadratic.TabIndex = 7;
            this.solve_quadratic.Text = "Oblicz x";
            this.solve_quadratic.UseVisualStyleBackColor = true;
            this.solve_quadratic.Click += new System.EventHandler(this.solve_quadratic_Click);
            // 
            // quad_c
            // 
            this.quad_c.Location = new System.Drawing.Point(418, 74);
            this.quad_c.Name = "quad_c";
            this.quad_c.Size = new System.Drawing.Size(50, 20);
            this.quad_c.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "c";
            // 
            // quad_b
            // 
            this.quad_b.Location = new System.Drawing.Point(252, 74);
            this.quad_b.Name = "quad_b";
            this.quad_b.Size = new System.Drawing.Size(50, 20);
            this.quad_b.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "b";
            // 
            // quad_a
            // 
            this.quad_a.Location = new System.Drawing.Point(94, 74);
            this.quad_a.Name = "quad_a";
            this.quad_a.Size = new System.Drawing.Size(50, 20);
            this.quad_a.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Podaj parametry a,b,c równania kwadratowego w postaci ogólnej, tj\r\n              " +
    "                            ax^2+bx+c=0";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.linkLabel6);
            this.tabPage4.Controls.Add(this.linkLabel5);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.linkLabel4);
            this.tabPage4.Controls.Add(this.linkLabel3);
            this.tabPage4.Controls.Add(this.linkLabel2);
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(574, 261);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Przydatne narzędzia";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel6.Location = new System.Drawing.Point(339, 225);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(113, 13);
            this.linkLabel6.TabIndex = 11;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "https://www.google.pl";
            this.toolTip1.SetToolTip(this.linkLabel6, "Kliknięcie śledzi łącze");
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel5.Location = new System.Drawing.Point(339, 189);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(93, 13);
            this.linkLabel5.TabIndex = 10;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "https://cke.gov.pl";
            this.toolTip1.SetToolTip(this.linkLabel5, "Kliknięcie śledzi łącze");
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Tablice matematyczne CKE";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel4.Location = new System.Drawing.Point(339, 152);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(80, 13);
            this.linkLabel4.TabIndex = 8;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "https://oeis.org";
            this.toolTip1.SetToolTip(this.linkLabel4, "Kliknięcie śledzi łącze");
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Location = new System.Drawing.Point(339, 114);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(147, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://matematykaszkolna.pl";
            this.toolTip1.SetToolTip(this.linkLabel3, "Kliknięcie śledzi łącze");
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Location = new System.Drawing.Point(339, 74);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(133, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://www.geogebra.org";
            this.toolTip1.SetToolTip(this.linkLabel2, "Kliknięcie śledzi łącze");
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(339, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.wolframalpha.com";
            this.toolTip1.SetToolTip(this.linkLabel1, "Kliknięcie śledzi łącze\r\n");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 225);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(224, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "I oczywiście najprzydatniejsze narzędzie, czyli:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "OEIS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "MatematykaSzkolna";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Geogebra";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Wolfram Alpha";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.działaniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Image = global::ProgramMatFiz.Properties.Resources.close;
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "&Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // działaniaToolStripMenuItem
            // 
            this.działaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obliczToolStripMenuItem,
            this.czyśćToolStripMenuItem,
            this.pomocToolStripMenuItem1});
            this.działaniaToolStripMenuItem.Name = "działaniaToolStripMenuItem";
            this.działaniaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.działaniaToolStripMenuItem.Text = "&Działania";
            // 
            // obliczToolStripMenuItem
            // 
            this.obliczToolStripMenuItem.Name = "obliczToolStripMenuItem";
            this.obliczToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.obliczToolStripMenuItem.Text = "&Oblicz";
            this.obliczToolStripMenuItem.Click += new System.EventHandler(this.obliczToolStripMenuItem_Click);
            // 
            // czyśćToolStripMenuItem
            // 
            this.czyśćToolStripMenuItem.Name = "czyśćToolStripMenuItem";
            this.czyśćToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.czyśćToolStripMenuItem.Text = "&Czyść";
            this.czyśćToolStripMenuItem.Click += new System.EventHandler(this.czyśćToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.pomocToolStripMenuItem1.Text = "&Pomoc";
            this.pomocToolStripMenuItem1.Click += new System.EventHandler(this.pomocToolStripMenuItem1_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.pomocToolStripMenuItem.Text = "&Informacje";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obliczToolStripMenuItem1,
            this.czyśćToolStripMenuItem1,
            this.pomocToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
            // 
            // obliczToolStripMenuItem1
            // 
            this.obliczToolStripMenuItem1.Name = "obliczToolStripMenuItem1";
            this.obliczToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.obliczToolStripMenuItem1.Text = "Oblicz";
            this.obliczToolStripMenuItem1.Click += new System.EventHandler(this.obliczToolStripMenuItem1_Click);
            // 
            // czyśćToolStripMenuItem1
            // 
            this.czyśćToolStripMenuItem1.Name = "czyśćToolStripMenuItem1";
            this.czyśćToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.czyśćToolStripMenuItem1.Text = "Czyść";
            this.czyśćToolStripMenuItem1.Click += new System.EventHandler(this.czyśćToolStripMenuItem1_Click);
            // 
            // pomocToolStripMenuItem2
            // 
            this.pomocToolStripMenuItem2.Name = "pomocToolStripMenuItem2";
            this.pomocToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.pomocToolStripMenuItem2.Text = "Pomoc";
            this.pomocToolStripMenuItem2.Click += new System.EventHandler(this.pomocToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 345);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatFizCalc";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.rownanie_kwadratowe.ResumeLayout(false);
            this.rownanie_kwadratowe.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button calc1;
        public System.Windows.Forms.TextBox alpha_box;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ctg_box;
        public System.Windows.Forms.TextBox tg_box;
        public System.Windows.Forms.TextBox cos_box;
        public System.Windows.Forms.TextBox sin_box;
        public System.Windows.Forms.Label ctg_label;
        public System.Windows.Forms.Label tg_label;
        public System.Windows.Forms.Label cos_label;
        public System.Windows.Forms.Label sin_label;
        public System.Windows.Forms.TextBox v0_box;
        public System.Windows.Forms.TextBox vy_box;
        public System.Windows.Forms.TextBox vx_box;
        public System.Windows.Forms.Label v0;
        public System.Windows.Forms.Label vy;
        public System.Windows.Forms.Label vx;
        public System.Windows.Forms.Button clear1;
        public System.Windows.Forms.Button help_vectors;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ctg_box_trig;
        public System.Windows.Forms.TextBox tg_box_trig;
        public System.Windows.Forms.TextBox cos_box_trig;
        public System.Windows.Forms.TextBox sin_box_trig;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox alpha_box_trig;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox angle_unit_selector;
        public System.Windows.Forms.Button solve_trig;
        public System.Windows.Forms.Button clear_trig;
        public System.Windows.Forms.Button help_trig;
        public System.Windows.Forms.TabPage rownanie_kwadratowe;
        public System.Windows.Forms.TextBox quad_c;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox quad_b;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox quad_a;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.Button solve_quadratic;
        public System.Windows.Forms.Button clear_quadratic;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox quad_result;
        public System.Windows.Forms.Button help_quadratic;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem działaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obliczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obliczToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem czyśćToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem2;
    }
}

