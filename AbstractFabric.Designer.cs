namespace Patterns
{
    partial class AbstractFactory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbstractFactory));
            panel1 = new Panel();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            create = new Button();
            height = new TextBox();
            labelforHeight = new Label();
            labelForWidth = new Label();
            width = new TextBox();
            style = new ComboBox();
            items = new ComboBox();
            styleForItem = new Label();
            labelForItem = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            Loots = new DataGridView();
            menuStrip1 = new MenuStrip();
            sdfsdfsdfToolStripMenuItem = new ToolStripMenuItem();
            закрытьToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem1 = new ToolStripMenuItem();
            новыйТоварToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            столбцыToolStripMenuItem = new ToolStripMenuItem();
            строкиToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            столбецToolStripMenuItem = new ToolStripMenuItem();
            строкуToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem1 = new ToolStripMenuItem();
            темаToolStripMenuItem = new ToolStripMenuItem();
            светлаяToolStripMenuItem = new ToolStripMenuItem();
            тёмнаяToolStripMenuItem = new ToolStripMenuItem();
            упорядочитьToolStripMenuItem = new ToolStripMenuItem();
            поСтилюToolStripMenuItem = new ToolStripMenuItem();
            поИмениToolStripMenuItem = new ToolStripMenuItem();
            поГабаритуToolStripMenuItem = new ToolStripMenuItem();
            показатьToolStripMenuItem = new ToolStripMenuItem();
            всёToolStripMenuItem = new ToolStripMenuItem();
            толькоСтульяToolStripMenuItem = new ToolStripMenuItem();
            толькоКреслаToolStripMenuItem = new ToolStripMenuItem();
            толькоДиваныToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Loots).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(Loots);
            panel1.Name = "panel1";
            // 
            // listBox1
            // 
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.Name = "listBox1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(create);
            groupBox3.Controls.Add(height);
            groupBox3.Controls.Add(labelforHeight);
            groupBox3.Controls.Add(labelForWidth);
            groupBox3.Controls.Add(width);
            groupBox3.Controls.Add(style);
            groupBox3.Controls.Add(items);
            groupBox3.Controls.Add(styleForItem);
            groupBox3.Controls.Add(labelForItem);
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // create
            // 
            resources.ApplyResources(create, "create");
            create.Name = "create";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // height
            // 
            resources.ApplyResources(height, "height");
            height.Name = "height";
            // 
            // labelforHeight
            // 
            resources.ApplyResources(labelforHeight, "labelforHeight");
            labelforHeight.Name = "labelforHeight";
            // 
            // labelForWidth
            // 
            resources.ApplyResources(labelForWidth, "labelForWidth");
            labelForWidth.Name = "labelForWidth";
            // 
            // width
            // 
            resources.ApplyResources(width, "width");
            width.Name = "width";
            // 
            // style
            // 
            resources.ApplyResources(style, "style");
            style.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("style.AutoCompleteCustomSource"), resources.GetString("style.AutoCompleteCustomSource1") });
            style.FormattingEnabled = true;
            style.Items.AddRange(new object[] { resources.GetString("style.Items"), resources.GetString("style.Items1"), resources.GetString("style.Items2") });
            style.Name = "style";
            style.SelectedValueChanged += styleFurnitureChanged;
            // 
            // items
            // 
            resources.ApplyResources(items, "items");
            items.FormattingEnabled = true;
            items.Items.AddRange(new object[] { resources.GetString("items.Items"), resources.GetString("items.Items1"), resources.GetString("items.Items2"), resources.GetString("items.Items3") });
            items.Name = "items";
            // 
            // styleForItem
            // 
            resources.ApplyResources(styleForItem, "styleForItem");
            styleForItem.Name = "styleForItem";
            // 
            // labelForItem
            // 
            resources.ApplyResources(labelForItem, "labelForItem");
            labelForItem.Name = "labelForItem";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseCompatibleTextRendering = true;
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Loots
            // 
            resources.ApplyResources(Loots, "Loots");
            Loots.BorderStyle = BorderStyle.Fixed3D;
            Loots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Loots.Name = "Loots";
            Loots.RowTemplate.Height = 25;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { sdfsdfsdfToolStripMenuItem, видToolStripMenuItem, видToolStripMenuItem1 });
            menuStrip1.Name = "menuStrip1";
            // 
            // sdfsdfsdfToolStripMenuItem
            // 
            resources.ApplyResources(sdfsdfsdfToolStripMenuItem, "sdfsdfsdfToolStripMenuItem");
            sdfsdfsdfToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { закрытьToolStripMenuItem, создатьToolStripMenuItem1 });
            sdfsdfsdfToolStripMenuItem.Name = "sdfsdfsdfToolStripMenuItem";
            // 
            // закрытьToolStripMenuItem
            // 
            resources.ApplyResources(закрытьToolStripMenuItem, "закрытьToolStripMenuItem");
            закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            // 
            // создатьToolStripMenuItem1
            // 
            resources.ApplyResources(создатьToolStripMenuItem1, "создатьToolStripMenuItem1");
            создатьToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { новыйТоварToolStripMenuItem });
            создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            // 
            // новыйТоварToolStripMenuItem
            // 
            resources.ApplyResources(новыйТоварToolStripMenuItem, "новыйТоварToolStripMenuItem");
            новыйТоварToolStripMenuItem.Name = "новыйТоварToolStripMenuItem";
            // 
            // видToolStripMenuItem
            // 
            resources.ApplyResources(видToolStripMenuItem, "видToolStripMenuItem");
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, удалитьToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            // 
            // создатьToolStripMenuItem
            // 
            resources.ApplyResources(создатьToolStripMenuItem, "создатьToolStripMenuItem");
            создатьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { столбцыToolStripMenuItem, строкиToolStripMenuItem });
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            // 
            // столбцыToolStripMenuItem
            // 
            resources.ApplyResources(столбцыToolStripMenuItem, "столбцыToolStripMenuItem");
            столбцыToolStripMenuItem.Name = "столбцыToolStripMenuItem";
            // 
            // строкиToolStripMenuItem
            // 
            resources.ApplyResources(строкиToolStripMenuItem, "строкиToolStripMenuItem");
            строкиToolStripMenuItem.Name = "строкиToolStripMenuItem";
            // 
            // удалитьToolStripMenuItem
            // 
            resources.ApplyResources(удалитьToolStripMenuItem, "удалитьToolStripMenuItem");
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { столбецToolStripMenuItem, строкуToolStripMenuItem });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            // 
            // столбецToolStripMenuItem
            // 
            resources.ApplyResources(столбецToolStripMenuItem, "столбецToolStripMenuItem");
            столбецToolStripMenuItem.Name = "столбецToolStripMenuItem";
            // 
            // строкуToolStripMenuItem
            // 
            resources.ApplyResources(строкуToolStripMenuItem, "строкуToolStripMenuItem");
            строкуToolStripMenuItem.Name = "строкуToolStripMenuItem";
            // 
            // видToolStripMenuItem1
            // 
            resources.ApplyResources(видToolStripMenuItem1, "видToolStripMenuItem1");
            видToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { темаToolStripMenuItem, упорядочитьToolStripMenuItem, показатьToolStripMenuItem });
            видToolStripMenuItem1.Name = "видToolStripMenuItem1";
            // 
            // темаToolStripMenuItem
            // 
            resources.ApplyResources(темаToolStripMenuItem, "темаToolStripMenuItem");
            темаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { светлаяToolStripMenuItem, тёмнаяToolStripMenuItem });
            темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            // 
            // светлаяToolStripMenuItem
            // 
            resources.ApplyResources(светлаяToolStripMenuItem, "светлаяToolStripMenuItem");
            светлаяToolStripMenuItem.Checked = true;
            светлаяToolStripMenuItem.CheckState = CheckState.Checked;
            светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            // 
            // тёмнаяToolStripMenuItem
            // 
            resources.ApplyResources(тёмнаяToolStripMenuItem, "тёмнаяToolStripMenuItem");
            тёмнаяToolStripMenuItem.Name = "тёмнаяToolStripMenuItem";
            // 
            // упорядочитьToolStripMenuItem
            // 
            resources.ApplyResources(упорядочитьToolStripMenuItem, "упорядочитьToolStripMenuItem");
            упорядочитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поСтилюToolStripMenuItem, поИмениToolStripMenuItem, поГабаритуToolStripMenuItem });
            упорядочитьToolStripMenuItem.Name = "упорядочитьToolStripMenuItem";
            // 
            // поСтилюToolStripMenuItem
            // 
            resources.ApplyResources(поСтилюToolStripMenuItem, "поСтилюToolStripMenuItem");
            поСтилюToolStripMenuItem.Name = "поСтилюToolStripMenuItem";
            // 
            // поИмениToolStripMenuItem
            // 
            resources.ApplyResources(поИмениToolStripMenuItem, "поИмениToolStripMenuItem");
            поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            // 
            // поГабаритуToolStripMenuItem
            // 
            resources.ApplyResources(поГабаритуToolStripMenuItem, "поГабаритуToolStripMenuItem");
            поГабаритуToolStripMenuItem.Checked = true;
            поГабаритуToolStripMenuItem.CheckState = CheckState.Checked;
            поГабаритуToolStripMenuItem.Name = "поГабаритуToolStripMenuItem";
            // 
            // показатьToolStripMenuItem
            // 
            resources.ApplyResources(показатьToolStripMenuItem, "показатьToolStripMenuItem");
            показатьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { всёToolStripMenuItem, толькоСтульяToolStripMenuItem, толькоКреслаToolStripMenuItem, толькоДиваныToolStripMenuItem });
            показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            // 
            // всёToolStripMenuItem
            // 
            resources.ApplyResources(всёToolStripMenuItem, "всёToolStripMenuItem");
            всёToolStripMenuItem.Checked = true;
            всёToolStripMenuItem.CheckState = CheckState.Checked;
            всёToolStripMenuItem.Name = "всёToolStripMenuItem";
            // 
            // толькоСтульяToolStripMenuItem
            // 
            resources.ApplyResources(толькоСтульяToolStripMenuItem, "толькоСтульяToolStripMenuItem");
            толькоСтульяToolStripMenuItem.Name = "толькоСтульяToolStripMenuItem";
            // 
            // толькоКреслаToolStripMenuItem
            // 
            resources.ApplyResources(толькоКреслаToolStripMenuItem, "толькоКреслаToolStripMenuItem");
            толькоКреслаToolStripMenuItem.Name = "толькоКреслаToolStripMenuItem";
            // 
            // толькоДиваныToolStripMenuItem
            // 
            resources.ApplyResources(толькоДиваныToolStripMenuItem, "толькоДиваныToolStripMenuItem");
            толькоДиваныToolStripMenuItem.Name = "толькоДиваныToolStripMenuItem";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // AbstractFactory
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "AbstractFactory";
            Load += AbstractFabric_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Loots).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sdfsdfsdfToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private DataGridView Loots;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem столбцыToolStripMenuItem;
        private ToolStripMenuItem строкиToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem столбецToolStripMenuItem;
        private ToolStripMenuItem строкуToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
        private ToolStripMenuItem темаToolStripMenuItem;
        private ToolStripMenuItem светлаяToolStripMenuItem;
        private ToolStripMenuItem тёмнаяToolStripMenuItem;
        private ToolStripMenuItem упорядочитьToolStripMenuItem;
        private ToolStripMenuItem поСтилюToolStripMenuItem;
        private ToolStripMenuItem поИмениToolStripMenuItem;
        private ToolStripMenuItem поГабаритуToolStripMenuItem;
        private ToolStripMenuItem показатьToolStripMenuItem;
        private ToolStripMenuItem всёToolStripMenuItem;
        private ToolStripMenuItem толькоСтульяToolStripMenuItem;
        private ToolStripMenuItem толькоКреслаToolStripMenuItem;
        private ToolStripMenuItem толькоДиваныToolStripMenuItem;
        private Button button5;
        private ToolStripMenuItem создатьToolStripMenuItem1;
        private ToolStripMenuItem новыйТоварToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label labelForItem;
        private ComboBox items;
        private Label styleForItem;
        private TextBox height;
        private Label labelforHeight;
        private Label labelForWidth;
        private TextBox width;
        private ComboBox style;
        private Button create;
        private ListBox listBox1;
        private Label label1;
    }
}
