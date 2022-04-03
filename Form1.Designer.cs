namespace NUTs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nuts_menu = new System.Windows.Forms.MenuStrip();
            this.languages_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchtoen_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.switchtofr_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.themes_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lTheme_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.dTheme_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.nuts_tabSlctr = new MaterialSkin.Controls.MaterialTabSelector();
            this.nuts_tabCtrl = new MaterialSkin.Controls.MaterialTabControl();
            this.netsettings_tabCtrl = new System.Windows.Forms.TabPage();
            this.retrieve_btn = new MaterialSkin.Controls.MaterialButton();
            this.secdns_TxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.primdns_TxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.defgateway_TxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.subnetmask_TxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ip_TxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.secdns_RichTxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.primdns_RichTxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.defgateway_RichTxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.subnetmask_RichTxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ip_RichTxtBx1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.changenetsettings_tabCtrl = new System.Windows.Forms.TabPage();
            this.static_btn = new MaterialSkin.Controls.MaterialButton();
            this.dhcp_btn = new MaterialSkin.Controls.MaterialButton();
            this.secdns_TxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.primdns_TxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.defgateway_TxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.subnetmask_TxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ip_TxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.secdns_RichTxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.primdns_RichTxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.defgateway_RichTxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.subnetmask_RichTxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ip_RichTxtBx2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.nuts_menu.SuspendLayout();
            this.nuts_tabCtrl.SuspendLayout();
            this.netsettings_tabCtrl.SuspendLayout();
            this.changenetsettings_tabCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // nuts_menu
            // 
            this.nuts_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languages_menuItem,
            this.themes_menuItem});
            this.nuts_menu.Location = new System.Drawing.Point(3, 64);
            this.nuts_menu.Name = "nuts_menu";
            this.nuts_menu.Size = new System.Drawing.Size(647, 24);
            this.nuts_menu.TabIndex = 0;
            this.nuts_menu.Text = "menuStrip1";
            // 
            // languages_menuItem
            // 
            this.languages_menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchtoen_btn,
            this.switchtofr_btn});
            this.languages_menuItem.Name = "languages_menuItem";
            this.languages_menuItem.Size = new System.Drawing.Size(76, 20);
            this.languages_menuItem.Text = "Languages";
            // 
            // switchtoen_btn
            // 
            this.switchtoen_btn.Name = "switchtoen_btn";
            this.switchtoen_btn.Size = new System.Drawing.Size(164, 22);
            this.switchtoen_btn.Text = "Switch to english";
            this.switchtoen_btn.Click += new System.EventHandler(this.chng_EN);
            // 
            // switchtofr_btn
            // 
            this.switchtofr_btn.Name = "switchtofr_btn";
            this.switchtofr_btn.Size = new System.Drawing.Size(164, 22);
            this.switchtofr_btn.Text = "Switch to french";
            this.switchtofr_btn.Click += new System.EventHandler(this.chng_FR);
            // 
            // themes_menuItem
            // 
            this.themes_menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lTheme_btn,
            this.dTheme_btn});
            this.themes_menuItem.Name = "themes_menuItem";
            this.themes_menuItem.Size = new System.Drawing.Size(60, 20);
            this.themes_menuItem.Text = "Themes";
            // 
            // lTheme_btn
            // 
            this.lTheme_btn.Name = "lTheme_btn";
            this.lTheme_btn.Size = new System.Drawing.Size(173, 22);
            this.lTheme_btn.Text = "Enable light theme";
            this.lTheme_btn.Click += new System.EventHandler(this.apply_lTheme);
            // 
            // dTheme_btn
            // 
            this.dTheme_btn.Name = "dTheme_btn";
            this.dTheme_btn.Size = new System.Drawing.Size(173, 22);
            this.dTheme_btn.Text = "Enable dark theme";
            this.dTheme_btn.Click += new System.EventHandler(this.apply_dTheme);
            // 
            // nuts_tabSlctr
            // 
            this.nuts_tabSlctr.BaseTabControl = this.nuts_tabCtrl;
            this.nuts_tabSlctr.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.nuts_tabSlctr.Depth = 0;
            this.nuts_tabSlctr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nuts_tabSlctr.Location = new System.Drawing.Point(3, 91);
            this.nuts_tabSlctr.MouseState = MaterialSkin.MouseState.HOVER;
            this.nuts_tabSlctr.Name = "nuts_tabSlctr";
            this.nuts_tabSlctr.Size = new System.Drawing.Size(648, 48);
            this.nuts_tabSlctr.TabIndex = 1;
            this.nuts_tabSlctr.Text = "TabSelector";
            // 
            // nuts_tabCtrl
            // 
            this.nuts_tabCtrl.Controls.Add(this.netsettings_tabCtrl);
            this.nuts_tabCtrl.Controls.Add(this.changenetsettings_tabCtrl);
            this.nuts_tabCtrl.Depth = 0;
            this.nuts_tabCtrl.Location = new System.Drawing.Point(3, 145);
            this.nuts_tabCtrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.nuts_tabCtrl.Multiline = true;
            this.nuts_tabCtrl.Name = "nuts_tabCtrl";
            this.nuts_tabCtrl.SelectedIndex = 0;
            this.nuts_tabCtrl.Size = new System.Drawing.Size(648, 372);
            this.nuts_tabCtrl.TabIndex = 2;
            // 
            // netsettings_tabCtrl
            // 
            this.netsettings_tabCtrl.Controls.Add(this.retrieve_btn);
            this.netsettings_tabCtrl.Controls.Add(this.secdns_TxtBx1);
            this.netsettings_tabCtrl.Controls.Add(this.primdns_TxtBx1);
            this.netsettings_tabCtrl.Controls.Add(this.defgateway_TxtBx1);
            this.netsettings_tabCtrl.Controls.Add(this.subnetmask_TxtBx1);
            this.netsettings_tabCtrl.Controls.Add(this.ip_TxtBx1);
            this.netsettings_tabCtrl.Controls.Add(this.secdns_RichTxtBx1);
            this.netsettings_tabCtrl.Controls.Add(this.primdns_RichTxtBx1);
            this.netsettings_tabCtrl.Controls.Add(this.defgateway_RichTxtBx1);
            this.netsettings_tabCtrl.Controls.Add(this.subnetmask_RichTxtBx1);
            this.netsettings_tabCtrl.Controls.Add(this.ip_RichTxtBx1);
            this.netsettings_tabCtrl.Location = new System.Drawing.Point(4, 24);
            this.netsettings_tabCtrl.Name = "netsettings_tabCtrl";
            this.netsettings_tabCtrl.Padding = new System.Windows.Forms.Padding(3);
            this.netsettings_tabCtrl.Size = new System.Drawing.Size(640, 344);
            this.netsettings_tabCtrl.TabIndex = 0;
            this.netsettings_tabCtrl.Text = "Your network settings";
            this.netsettings_tabCtrl.UseVisualStyleBackColor = true;
            // 
            // retrieve_btn
            // 
            this.retrieve_btn.AutoSize = false;
            this.retrieve_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.retrieve_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.retrieve_btn.Depth = 0;
            this.retrieve_btn.HighEmphasis = true;
            this.retrieve_btn.Icon = null;
            this.retrieve_btn.Location = new System.Drawing.Point(202, 282);
            this.retrieve_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.retrieve_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.retrieve_btn.Name = "retrieve_btn";
            this.retrieve_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.retrieve_btn.Size = new System.Drawing.Size(233, 52);
            this.retrieve_btn.TabIndex = 10;
            this.retrieve_btn.Text = "RETRIEVE NETWORK SETTINGS";
            this.retrieve_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.retrieve_btn.UseAccentColor = false;
            this.retrieve_btn.UseVisualStyleBackColor = true;
            this.retrieve_btn.Click += new System.EventHandler(this.retrieve_Infos);
            // 
            // secdns_TxtBx1
            // 
            this.secdns_TxtBx1.AllowPromptAsInput = true;
            this.secdns_TxtBx1.AnimateReadOnly = false;
            this.secdns_TxtBx1.AsciiOnly = false;
            this.secdns_TxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.secdns_TxtBx1.BeepOnError = false;
            this.secdns_TxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.secdns_TxtBx1.Depth = 0;
            this.secdns_TxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.secdns_TxtBx1.HidePromptOnLeave = false;
            this.secdns_TxtBx1.HideSelection = true;
            this.secdns_TxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.secdns_TxtBx1.LeadingIcon = null;
            this.secdns_TxtBx1.Location = new System.Drawing.Point(379, 222);
            this.secdns_TxtBx1.Mask = "";
            this.secdns_TxtBx1.MaxLength = 32767;
            this.secdns_TxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.secdns_TxtBx1.Name = "secdns_TxtBx1";
            this.secdns_TxtBx1.PasswordChar = '\0';
            this.secdns_TxtBx1.PrefixSuffixText = null;
            this.secdns_TxtBx1.PromptChar = '_';
            this.secdns_TxtBx1.ReadOnly = true;
            this.secdns_TxtBx1.RejectInputOnFirstFailure = false;
            this.secdns_TxtBx1.ResetOnPrompt = true;
            this.secdns_TxtBx1.ResetOnSpace = true;
            this.secdns_TxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secdns_TxtBx1.SelectedText = "";
            this.secdns_TxtBx1.SelectionLength = 0;
            this.secdns_TxtBx1.SelectionStart = 0;
            this.secdns_TxtBx1.ShortcutsEnabled = true;
            this.secdns_TxtBx1.Size = new System.Drawing.Size(250, 48);
            this.secdns_TxtBx1.SkipLiterals = true;
            this.secdns_TxtBx1.TabIndex = 9;
            this.secdns_TxtBx1.TabStop = false;
            this.secdns_TxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.secdns_TxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.secdns_TxtBx1.TrailingIcon = null;
            this.secdns_TxtBx1.UseSystemPasswordChar = false;
            this.secdns_TxtBx1.ValidatingType = null;
            // 
            // primdns_TxtBx1
            // 
            this.primdns_TxtBx1.AllowPromptAsInput = true;
            this.primdns_TxtBx1.AnimateReadOnly = false;
            this.primdns_TxtBx1.AsciiOnly = false;
            this.primdns_TxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.primdns_TxtBx1.BeepOnError = false;
            this.primdns_TxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.primdns_TxtBx1.Depth = 0;
            this.primdns_TxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.primdns_TxtBx1.HidePromptOnLeave = false;
            this.primdns_TxtBx1.HideSelection = true;
            this.primdns_TxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.primdns_TxtBx1.LeadingIcon = null;
            this.primdns_TxtBx1.Location = new System.Drawing.Point(379, 168);
            this.primdns_TxtBx1.Mask = "";
            this.primdns_TxtBx1.MaxLength = 32767;
            this.primdns_TxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.primdns_TxtBx1.Name = "primdns_TxtBx1";
            this.primdns_TxtBx1.PasswordChar = '\0';
            this.primdns_TxtBx1.PrefixSuffixText = null;
            this.primdns_TxtBx1.PromptChar = '_';
            this.primdns_TxtBx1.ReadOnly = true;
            this.primdns_TxtBx1.RejectInputOnFirstFailure = false;
            this.primdns_TxtBx1.ResetOnPrompt = true;
            this.primdns_TxtBx1.ResetOnSpace = true;
            this.primdns_TxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.primdns_TxtBx1.SelectedText = "";
            this.primdns_TxtBx1.SelectionLength = 0;
            this.primdns_TxtBx1.SelectionStart = 0;
            this.primdns_TxtBx1.ShortcutsEnabled = true;
            this.primdns_TxtBx1.Size = new System.Drawing.Size(250, 48);
            this.primdns_TxtBx1.SkipLiterals = true;
            this.primdns_TxtBx1.TabIndex = 8;
            this.primdns_TxtBx1.TabStop = false;
            this.primdns_TxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.primdns_TxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.primdns_TxtBx1.TrailingIcon = null;
            this.primdns_TxtBx1.UseSystemPasswordChar = false;
            this.primdns_TxtBx1.ValidatingType = null;
            // 
            // defgateway_TxtBx1
            // 
            this.defgateway_TxtBx1.AllowPromptAsInput = true;
            this.defgateway_TxtBx1.AnimateReadOnly = false;
            this.defgateway_TxtBx1.AsciiOnly = false;
            this.defgateway_TxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.defgateway_TxtBx1.BeepOnError = false;
            this.defgateway_TxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.defgateway_TxtBx1.Depth = 0;
            this.defgateway_TxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.defgateway_TxtBx1.HidePromptOnLeave = false;
            this.defgateway_TxtBx1.HideSelection = true;
            this.defgateway_TxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.defgateway_TxtBx1.LeadingIcon = null;
            this.defgateway_TxtBx1.Location = new System.Drawing.Point(379, 114);
            this.defgateway_TxtBx1.Mask = "";
            this.defgateway_TxtBx1.MaxLength = 32767;
            this.defgateway_TxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.defgateway_TxtBx1.Name = "defgateway_TxtBx1";
            this.defgateway_TxtBx1.PasswordChar = '\0';
            this.defgateway_TxtBx1.PrefixSuffixText = null;
            this.defgateway_TxtBx1.PromptChar = '_';
            this.defgateway_TxtBx1.ReadOnly = true;
            this.defgateway_TxtBx1.RejectInputOnFirstFailure = false;
            this.defgateway_TxtBx1.ResetOnPrompt = true;
            this.defgateway_TxtBx1.ResetOnSpace = true;
            this.defgateway_TxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.defgateway_TxtBx1.SelectedText = "";
            this.defgateway_TxtBx1.SelectionLength = 0;
            this.defgateway_TxtBx1.SelectionStart = 0;
            this.defgateway_TxtBx1.ShortcutsEnabled = true;
            this.defgateway_TxtBx1.Size = new System.Drawing.Size(250, 48);
            this.defgateway_TxtBx1.SkipLiterals = true;
            this.defgateway_TxtBx1.TabIndex = 7;
            this.defgateway_TxtBx1.TabStop = false;
            this.defgateway_TxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.defgateway_TxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.defgateway_TxtBx1.TrailingIcon = null;
            this.defgateway_TxtBx1.UseSystemPasswordChar = false;
            this.defgateway_TxtBx1.ValidatingType = null;
            // 
            // subnetmask_TxtBx1
            // 
            this.subnetmask_TxtBx1.AllowPromptAsInput = true;
            this.subnetmask_TxtBx1.AnimateReadOnly = false;
            this.subnetmask_TxtBx1.AsciiOnly = false;
            this.subnetmask_TxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.subnetmask_TxtBx1.BeepOnError = false;
            this.subnetmask_TxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.subnetmask_TxtBx1.Depth = 0;
            this.subnetmask_TxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subnetmask_TxtBx1.HidePromptOnLeave = false;
            this.subnetmask_TxtBx1.HideSelection = true;
            this.subnetmask_TxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.subnetmask_TxtBx1.LeadingIcon = null;
            this.subnetmask_TxtBx1.Location = new System.Drawing.Point(379, 60);
            this.subnetmask_TxtBx1.Mask = "";
            this.subnetmask_TxtBx1.MaxLength = 32767;
            this.subnetmask_TxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.subnetmask_TxtBx1.Name = "subnetmask_TxtBx1";
            this.subnetmask_TxtBx1.PasswordChar = '\0';
            this.subnetmask_TxtBx1.PrefixSuffixText = null;
            this.subnetmask_TxtBx1.PromptChar = '_';
            this.subnetmask_TxtBx1.ReadOnly = true;
            this.subnetmask_TxtBx1.RejectInputOnFirstFailure = false;
            this.subnetmask_TxtBx1.ResetOnPrompt = true;
            this.subnetmask_TxtBx1.ResetOnSpace = true;
            this.subnetmask_TxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subnetmask_TxtBx1.SelectedText = "";
            this.subnetmask_TxtBx1.SelectionLength = 0;
            this.subnetmask_TxtBx1.SelectionStart = 0;
            this.subnetmask_TxtBx1.ShortcutsEnabled = true;
            this.subnetmask_TxtBx1.Size = new System.Drawing.Size(250, 48);
            this.subnetmask_TxtBx1.SkipLiterals = true;
            this.subnetmask_TxtBx1.TabIndex = 6;
            this.subnetmask_TxtBx1.TabStop = false;
            this.subnetmask_TxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.subnetmask_TxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.subnetmask_TxtBx1.TrailingIcon = null;
            this.subnetmask_TxtBx1.UseSystemPasswordChar = false;
            this.subnetmask_TxtBx1.ValidatingType = null;
            // 
            // ip_TxtBx1
            // 
            this.ip_TxtBx1.AllowPromptAsInput = true;
            this.ip_TxtBx1.AnimateReadOnly = false;
            this.ip_TxtBx1.AsciiOnly = false;
            this.ip_TxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ip_TxtBx1.BeepOnError = false;
            this.ip_TxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ip_TxtBx1.Depth = 0;
            this.ip_TxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ip_TxtBx1.HidePromptOnLeave = false;
            this.ip_TxtBx1.HideSelection = true;
            this.ip_TxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ip_TxtBx1.LeadingIcon = null;
            this.ip_TxtBx1.Location = new System.Drawing.Point(379, 6);
            this.ip_TxtBx1.Mask = "";
            this.ip_TxtBx1.MaxLength = 32767;
            this.ip_TxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.ip_TxtBx1.Name = "ip_TxtBx1";
            this.ip_TxtBx1.PasswordChar = '\0';
            this.ip_TxtBx1.PrefixSuffixText = null;
            this.ip_TxtBx1.PromptChar = '_';
            this.ip_TxtBx1.ReadOnly = true;
            this.ip_TxtBx1.RejectInputOnFirstFailure = false;
            this.ip_TxtBx1.ResetOnPrompt = true;
            this.ip_TxtBx1.ResetOnSpace = true;
            this.ip_TxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ip_TxtBx1.SelectedText = "";
            this.ip_TxtBx1.SelectionLength = 0;
            this.ip_TxtBx1.SelectionStart = 0;
            this.ip_TxtBx1.ShortcutsEnabled = true;
            this.ip_TxtBx1.Size = new System.Drawing.Size(250, 48);
            this.ip_TxtBx1.SkipLiterals = true;
            this.ip_TxtBx1.TabIndex = 5;
            this.ip_TxtBx1.TabStop = false;
            this.ip_TxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ip_TxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ip_TxtBx1.TrailingIcon = null;
            this.ip_TxtBx1.UseSystemPasswordChar = false;
            this.ip_TxtBx1.ValidatingType = null;
            // 
            // secdns_RichTxtBx1
            // 
            this.secdns_RichTxtBx1.AllowPromptAsInput = true;
            this.secdns_RichTxtBx1.AnimateReadOnly = false;
            this.secdns_RichTxtBx1.AsciiOnly = false;
            this.secdns_RichTxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.secdns_RichTxtBx1.BeepOnError = false;
            this.secdns_RichTxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.secdns_RichTxtBx1.Depth = 0;
            this.secdns_RichTxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.secdns_RichTxtBx1.HidePromptOnLeave = false;
            this.secdns_RichTxtBx1.HideSelection = true;
            this.secdns_RichTxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.secdns_RichTxtBx1.LeadingIcon = null;
            this.secdns_RichTxtBx1.Location = new System.Drawing.Point(6, 222);
            this.secdns_RichTxtBx1.Mask = "";
            this.secdns_RichTxtBx1.MaxLength = 32767;
            this.secdns_RichTxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.secdns_RichTxtBx1.Name = "secdns_RichTxtBx1";
            this.secdns_RichTxtBx1.PasswordChar = '\0';
            this.secdns_RichTxtBx1.PrefixSuffixText = null;
            this.secdns_RichTxtBx1.PromptChar = '_';
            this.secdns_RichTxtBx1.ReadOnly = true;
            this.secdns_RichTxtBx1.RejectInputOnFirstFailure = false;
            this.secdns_RichTxtBx1.ResetOnPrompt = true;
            this.secdns_RichTxtBx1.ResetOnSpace = true;
            this.secdns_RichTxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secdns_RichTxtBx1.SelectedText = "";
            this.secdns_RichTxtBx1.SelectionLength = 0;
            this.secdns_RichTxtBx1.SelectionStart = 0;
            this.secdns_RichTxtBx1.ShortcutsEnabled = true;
            this.secdns_RichTxtBx1.Size = new System.Drawing.Size(250, 48);
            this.secdns_RichTxtBx1.SkipLiterals = true;
            this.secdns_RichTxtBx1.TabIndex = 4;
            this.secdns_RichTxtBx1.TabStop = false;
            this.secdns_RichTxtBx1.Text = "Secondary DNS address";
            this.secdns_RichTxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.secdns_RichTxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.secdns_RichTxtBx1.TrailingIcon = null;
            this.secdns_RichTxtBx1.UseSystemPasswordChar = false;
            this.secdns_RichTxtBx1.ValidatingType = null;
            // 
            // primdns_RichTxtBx1
            // 
            this.primdns_RichTxtBx1.AllowPromptAsInput = true;
            this.primdns_RichTxtBx1.AnimateReadOnly = false;
            this.primdns_RichTxtBx1.AsciiOnly = false;
            this.primdns_RichTxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.primdns_RichTxtBx1.BeepOnError = false;
            this.primdns_RichTxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.primdns_RichTxtBx1.Depth = 0;
            this.primdns_RichTxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.primdns_RichTxtBx1.HidePromptOnLeave = false;
            this.primdns_RichTxtBx1.HideSelection = true;
            this.primdns_RichTxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.primdns_RichTxtBx1.LeadingIcon = null;
            this.primdns_RichTxtBx1.Location = new System.Drawing.Point(6, 168);
            this.primdns_RichTxtBx1.Mask = "";
            this.primdns_RichTxtBx1.MaxLength = 32767;
            this.primdns_RichTxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.primdns_RichTxtBx1.Name = "primdns_RichTxtBx1";
            this.primdns_RichTxtBx1.PasswordChar = '\0';
            this.primdns_RichTxtBx1.PrefixSuffixText = null;
            this.primdns_RichTxtBx1.PromptChar = '_';
            this.primdns_RichTxtBx1.ReadOnly = true;
            this.primdns_RichTxtBx1.RejectInputOnFirstFailure = false;
            this.primdns_RichTxtBx1.ResetOnPrompt = true;
            this.primdns_RichTxtBx1.ResetOnSpace = true;
            this.primdns_RichTxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.primdns_RichTxtBx1.SelectedText = "";
            this.primdns_RichTxtBx1.SelectionLength = 0;
            this.primdns_RichTxtBx1.SelectionStart = 0;
            this.primdns_RichTxtBx1.ShortcutsEnabled = true;
            this.primdns_RichTxtBx1.Size = new System.Drawing.Size(250, 48);
            this.primdns_RichTxtBx1.SkipLiterals = true;
            this.primdns_RichTxtBx1.TabIndex = 3;
            this.primdns_RichTxtBx1.TabStop = false;
            this.primdns_RichTxtBx1.Text = "Primary DNS address";
            this.primdns_RichTxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.primdns_RichTxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.primdns_RichTxtBx1.TrailingIcon = null;
            this.primdns_RichTxtBx1.UseSystemPasswordChar = false;
            this.primdns_RichTxtBx1.ValidatingType = null;
            // 
            // defgateway_RichTxtBx1
            // 
            this.defgateway_RichTxtBx1.AllowPromptAsInput = true;
            this.defgateway_RichTxtBx1.AnimateReadOnly = false;
            this.defgateway_RichTxtBx1.AsciiOnly = false;
            this.defgateway_RichTxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.defgateway_RichTxtBx1.BeepOnError = false;
            this.defgateway_RichTxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.defgateway_RichTxtBx1.Depth = 0;
            this.defgateway_RichTxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.defgateway_RichTxtBx1.HidePromptOnLeave = false;
            this.defgateway_RichTxtBx1.HideSelection = true;
            this.defgateway_RichTxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.defgateway_RichTxtBx1.LeadingIcon = null;
            this.defgateway_RichTxtBx1.Location = new System.Drawing.Point(6, 114);
            this.defgateway_RichTxtBx1.Mask = "";
            this.defgateway_RichTxtBx1.MaxLength = 32767;
            this.defgateway_RichTxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.defgateway_RichTxtBx1.Name = "defgateway_RichTxtBx1";
            this.defgateway_RichTxtBx1.PasswordChar = '\0';
            this.defgateway_RichTxtBx1.PrefixSuffixText = null;
            this.defgateway_RichTxtBx1.PromptChar = '_';
            this.defgateway_RichTxtBx1.ReadOnly = true;
            this.defgateway_RichTxtBx1.RejectInputOnFirstFailure = false;
            this.defgateway_RichTxtBx1.ResetOnPrompt = true;
            this.defgateway_RichTxtBx1.ResetOnSpace = true;
            this.defgateway_RichTxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.defgateway_RichTxtBx1.SelectedText = "";
            this.defgateway_RichTxtBx1.SelectionLength = 0;
            this.defgateway_RichTxtBx1.SelectionStart = 0;
            this.defgateway_RichTxtBx1.ShortcutsEnabled = true;
            this.defgateway_RichTxtBx1.Size = new System.Drawing.Size(250, 48);
            this.defgateway_RichTxtBx1.SkipLiterals = true;
            this.defgateway_RichTxtBx1.TabIndex = 2;
            this.defgateway_RichTxtBx1.TabStop = false;
            this.defgateway_RichTxtBx1.Text = "Default gateway";
            this.defgateway_RichTxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.defgateway_RichTxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.defgateway_RichTxtBx1.TrailingIcon = null;
            this.defgateway_RichTxtBx1.UseSystemPasswordChar = false;
            this.defgateway_RichTxtBx1.ValidatingType = null;
            // 
            // subnetmask_RichTxtBx1
            // 
            this.subnetmask_RichTxtBx1.AllowPromptAsInput = true;
            this.subnetmask_RichTxtBx1.AnimateReadOnly = false;
            this.subnetmask_RichTxtBx1.AsciiOnly = false;
            this.subnetmask_RichTxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.subnetmask_RichTxtBx1.BeepOnError = false;
            this.subnetmask_RichTxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.subnetmask_RichTxtBx1.Depth = 0;
            this.subnetmask_RichTxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subnetmask_RichTxtBx1.HidePromptOnLeave = false;
            this.subnetmask_RichTxtBx1.HideSelection = true;
            this.subnetmask_RichTxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.subnetmask_RichTxtBx1.LeadingIcon = null;
            this.subnetmask_RichTxtBx1.Location = new System.Drawing.Point(6, 60);
            this.subnetmask_RichTxtBx1.Mask = "";
            this.subnetmask_RichTxtBx1.MaxLength = 32767;
            this.subnetmask_RichTxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.subnetmask_RichTxtBx1.Name = "subnetmask_RichTxtBx1";
            this.subnetmask_RichTxtBx1.PasswordChar = '\0';
            this.subnetmask_RichTxtBx1.PrefixSuffixText = null;
            this.subnetmask_RichTxtBx1.PromptChar = '_';
            this.subnetmask_RichTxtBx1.ReadOnly = true;
            this.subnetmask_RichTxtBx1.RejectInputOnFirstFailure = false;
            this.subnetmask_RichTxtBx1.ResetOnPrompt = true;
            this.subnetmask_RichTxtBx1.ResetOnSpace = true;
            this.subnetmask_RichTxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subnetmask_RichTxtBx1.SelectedText = "";
            this.subnetmask_RichTxtBx1.SelectionLength = 0;
            this.subnetmask_RichTxtBx1.SelectionStart = 0;
            this.subnetmask_RichTxtBx1.ShortcutsEnabled = true;
            this.subnetmask_RichTxtBx1.Size = new System.Drawing.Size(250, 48);
            this.subnetmask_RichTxtBx1.SkipLiterals = true;
            this.subnetmask_RichTxtBx1.TabIndex = 1;
            this.subnetmask_RichTxtBx1.TabStop = false;
            this.subnetmask_RichTxtBx1.Text = "Subnet mask";
            this.subnetmask_RichTxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.subnetmask_RichTxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.subnetmask_RichTxtBx1.TrailingIcon = null;
            this.subnetmask_RichTxtBx1.UseSystemPasswordChar = false;
            this.subnetmask_RichTxtBx1.ValidatingType = null;
            // 
            // ip_RichTxtBx1
            // 
            this.ip_RichTxtBx1.AllowPromptAsInput = true;
            this.ip_RichTxtBx1.AnimateReadOnly = false;
            this.ip_RichTxtBx1.AsciiOnly = false;
            this.ip_RichTxtBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ip_RichTxtBx1.BeepOnError = false;
            this.ip_RichTxtBx1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ip_RichTxtBx1.Depth = 0;
            this.ip_RichTxtBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ip_RichTxtBx1.HidePromptOnLeave = false;
            this.ip_RichTxtBx1.HideSelection = true;
            this.ip_RichTxtBx1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ip_RichTxtBx1.LeadingIcon = null;
            this.ip_RichTxtBx1.Location = new System.Drawing.Point(3, 6);
            this.ip_RichTxtBx1.Mask = "";
            this.ip_RichTxtBx1.MaxLength = 32767;
            this.ip_RichTxtBx1.MouseState = MaterialSkin.MouseState.OUT;
            this.ip_RichTxtBx1.Name = "ip_RichTxtBx1";
            this.ip_RichTxtBx1.PasswordChar = '\0';
            this.ip_RichTxtBx1.PrefixSuffixText = null;
            this.ip_RichTxtBx1.PromptChar = '_';
            this.ip_RichTxtBx1.ReadOnly = true;
            this.ip_RichTxtBx1.RejectInputOnFirstFailure = false;
            this.ip_RichTxtBx1.ResetOnPrompt = true;
            this.ip_RichTxtBx1.ResetOnSpace = true;
            this.ip_RichTxtBx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ip_RichTxtBx1.SelectedText = "";
            this.ip_RichTxtBx1.SelectionLength = 0;
            this.ip_RichTxtBx1.SelectionStart = 0;
            this.ip_RichTxtBx1.ShortcutsEnabled = true;
            this.ip_RichTxtBx1.Size = new System.Drawing.Size(250, 48);
            this.ip_RichTxtBx1.SkipLiterals = true;
            this.ip_RichTxtBx1.TabIndex = 0;
            this.ip_RichTxtBx1.TabStop = false;
            this.ip_RichTxtBx1.Text = "IP Address";
            this.ip_RichTxtBx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ip_RichTxtBx1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ip_RichTxtBx1.TrailingIcon = null;
            this.ip_RichTxtBx1.UseSystemPasswordChar = false;
            this.ip_RichTxtBx1.ValidatingType = null;
            // 
            // changenetsettings_tabCtrl
            // 
            this.changenetsettings_tabCtrl.Controls.Add(this.static_btn);
            this.changenetsettings_tabCtrl.Controls.Add(this.dhcp_btn);
            this.changenetsettings_tabCtrl.Controls.Add(this.secdns_TxtBx2);
            this.changenetsettings_tabCtrl.Controls.Add(this.primdns_TxtBx2);
            this.changenetsettings_tabCtrl.Controls.Add(this.defgateway_TxtBx2);
            this.changenetsettings_tabCtrl.Controls.Add(this.subnetmask_TxtBx2);
            this.changenetsettings_tabCtrl.Controls.Add(this.ip_TxtBx2);
            this.changenetsettings_tabCtrl.Controls.Add(this.secdns_RichTxtBx2);
            this.changenetsettings_tabCtrl.Controls.Add(this.primdns_RichTxtBx2);
            this.changenetsettings_tabCtrl.Controls.Add(this.defgateway_RichTxtBx2);
            this.changenetsettings_tabCtrl.Controls.Add(this.subnetmask_RichTxtBx2);
            this.changenetsettings_tabCtrl.Controls.Add(this.ip_RichTxtBx2);
            this.changenetsettings_tabCtrl.Location = new System.Drawing.Point(4, 24);
            this.changenetsettings_tabCtrl.Name = "changenetsettings_tabCtrl";
            this.changenetsettings_tabCtrl.Padding = new System.Windows.Forms.Padding(3);
            this.changenetsettings_tabCtrl.Size = new System.Drawing.Size(640, 344);
            this.changenetsettings_tabCtrl.TabIndex = 1;
            this.changenetsettings_tabCtrl.Text = "Change your network settings";
            this.changenetsettings_tabCtrl.UseVisualStyleBackColor = true;
            // 
            // static_btn
            // 
            this.static_btn.AutoSize = false;
            this.static_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.static_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.static_btn.Depth = 0;
            this.static_btn.HighEmphasis = true;
            this.static_btn.Icon = null;
            this.static_btn.Location = new System.Drawing.Point(379, 279);
            this.static_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.static_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.static_btn.Name = "static_btn";
            this.static_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.static_btn.Size = new System.Drawing.Size(249, 52);
            this.static_btn.TabIndex = 21;
            this.static_btn.Text = "SET STATIC SETTINGS";
            this.static_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.static_btn.UseAccentColor = false;
            this.static_btn.UseVisualStyleBackColor = true;
            this.static_btn.Click += new System.EventHandler(this.set_StaticParams);
            // 
            // dhcp_btn
            // 
            this.dhcp_btn.AutoSize = false;
            this.dhcp_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dhcp_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.dhcp_btn.Depth = 0;
            this.dhcp_btn.HighEmphasis = true;
            this.dhcp_btn.Icon = null;
            this.dhcp_btn.Location = new System.Drawing.Point(7, 279);
            this.dhcp_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dhcp_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dhcp_btn.Name = "dhcp_btn";
            this.dhcp_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.dhcp_btn.Size = new System.Drawing.Size(246, 55);
            this.dhcp_btn.TabIndex = 20;
            this.dhcp_btn.Text = "SET DYNAMIC SETTINGS";
            this.dhcp_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dhcp_btn.UseAccentColor = false;
            this.dhcp_btn.UseVisualStyleBackColor = true;
            this.dhcp_btn.Click += new System.EventHandler(this.set_DynamicParams);
            // 
            // secdns_TxtBx2
            // 
            this.secdns_TxtBx2.AllowPromptAsInput = true;
            this.secdns_TxtBx2.AnimateReadOnly = false;
            this.secdns_TxtBx2.AsciiOnly = false;
            this.secdns_TxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.secdns_TxtBx2.BeepOnError = false;
            this.secdns_TxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.secdns_TxtBx2.Depth = 0;
            this.secdns_TxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.secdns_TxtBx2.HidePromptOnLeave = false;
            this.secdns_TxtBx2.HideSelection = true;
            this.secdns_TxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.secdns_TxtBx2.LeadingIcon = null;
            this.secdns_TxtBx2.Location = new System.Drawing.Point(379, 222);
            this.secdns_TxtBx2.Mask = "";
            this.secdns_TxtBx2.MaxLength = 32767;
            this.secdns_TxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.secdns_TxtBx2.Name = "secdns_TxtBx2";
            this.secdns_TxtBx2.PasswordChar = '\0';
            this.secdns_TxtBx2.PrefixSuffixText = null;
            this.secdns_TxtBx2.PromptChar = '_';
            this.secdns_TxtBx2.ReadOnly = false;
            this.secdns_TxtBx2.RejectInputOnFirstFailure = false;
            this.secdns_TxtBx2.ResetOnPrompt = true;
            this.secdns_TxtBx2.ResetOnSpace = true;
            this.secdns_TxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secdns_TxtBx2.SelectedText = "";
            this.secdns_TxtBx2.SelectionLength = 0;
            this.secdns_TxtBx2.SelectionStart = 0;
            this.secdns_TxtBx2.ShortcutsEnabled = true;
            this.secdns_TxtBx2.Size = new System.Drawing.Size(250, 48);
            this.secdns_TxtBx2.SkipLiterals = true;
            this.secdns_TxtBx2.TabIndex = 19;
            this.secdns_TxtBx2.TabStop = false;
            this.secdns_TxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.secdns_TxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.secdns_TxtBx2.TrailingIcon = null;
            this.secdns_TxtBx2.UseSystemPasswordChar = false;
            this.secdns_TxtBx2.ValidatingType = null;
            // 
            // primdns_TxtBx2
            // 
            this.primdns_TxtBx2.AllowPromptAsInput = true;
            this.primdns_TxtBx2.AnimateReadOnly = false;
            this.primdns_TxtBx2.AsciiOnly = false;
            this.primdns_TxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.primdns_TxtBx2.BeepOnError = false;
            this.primdns_TxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.primdns_TxtBx2.Depth = 0;
            this.primdns_TxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.primdns_TxtBx2.HidePromptOnLeave = false;
            this.primdns_TxtBx2.HideSelection = true;
            this.primdns_TxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.primdns_TxtBx2.LeadingIcon = null;
            this.primdns_TxtBx2.Location = new System.Drawing.Point(379, 168);
            this.primdns_TxtBx2.Mask = "";
            this.primdns_TxtBx2.MaxLength = 32767;
            this.primdns_TxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.primdns_TxtBx2.Name = "primdns_TxtBx2";
            this.primdns_TxtBx2.PasswordChar = '\0';
            this.primdns_TxtBx2.PrefixSuffixText = null;
            this.primdns_TxtBx2.PromptChar = '_';
            this.primdns_TxtBx2.ReadOnly = false;
            this.primdns_TxtBx2.RejectInputOnFirstFailure = false;
            this.primdns_TxtBx2.ResetOnPrompt = true;
            this.primdns_TxtBx2.ResetOnSpace = true;
            this.primdns_TxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.primdns_TxtBx2.SelectedText = "";
            this.primdns_TxtBx2.SelectionLength = 0;
            this.primdns_TxtBx2.SelectionStart = 0;
            this.primdns_TxtBx2.ShortcutsEnabled = true;
            this.primdns_TxtBx2.Size = new System.Drawing.Size(250, 48);
            this.primdns_TxtBx2.SkipLiterals = true;
            this.primdns_TxtBx2.TabIndex = 18;
            this.primdns_TxtBx2.TabStop = false;
            this.primdns_TxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.primdns_TxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.primdns_TxtBx2.TrailingIcon = null;
            this.primdns_TxtBx2.UseSystemPasswordChar = false;
            this.primdns_TxtBx2.ValidatingType = null;
            // 
            // defgateway_TxtBx2
            // 
            this.defgateway_TxtBx2.AllowPromptAsInput = true;
            this.defgateway_TxtBx2.AnimateReadOnly = false;
            this.defgateway_TxtBx2.AsciiOnly = false;
            this.defgateway_TxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.defgateway_TxtBx2.BeepOnError = false;
            this.defgateway_TxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.defgateway_TxtBx2.Depth = 0;
            this.defgateway_TxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.defgateway_TxtBx2.HidePromptOnLeave = false;
            this.defgateway_TxtBx2.HideSelection = true;
            this.defgateway_TxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.defgateway_TxtBx2.LeadingIcon = null;
            this.defgateway_TxtBx2.Location = new System.Drawing.Point(379, 114);
            this.defgateway_TxtBx2.Mask = "";
            this.defgateway_TxtBx2.MaxLength = 32767;
            this.defgateway_TxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.defgateway_TxtBx2.Name = "defgateway_TxtBx2";
            this.defgateway_TxtBx2.PasswordChar = '\0';
            this.defgateway_TxtBx2.PrefixSuffixText = null;
            this.defgateway_TxtBx2.PromptChar = '_';
            this.defgateway_TxtBx2.ReadOnly = false;
            this.defgateway_TxtBx2.RejectInputOnFirstFailure = false;
            this.defgateway_TxtBx2.ResetOnPrompt = true;
            this.defgateway_TxtBx2.ResetOnSpace = true;
            this.defgateway_TxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.defgateway_TxtBx2.SelectedText = "";
            this.defgateway_TxtBx2.SelectionLength = 0;
            this.defgateway_TxtBx2.SelectionStart = 0;
            this.defgateway_TxtBx2.ShortcutsEnabled = true;
            this.defgateway_TxtBx2.Size = new System.Drawing.Size(250, 48);
            this.defgateway_TxtBx2.SkipLiterals = true;
            this.defgateway_TxtBx2.TabIndex = 17;
            this.defgateway_TxtBx2.TabStop = false;
            this.defgateway_TxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.defgateway_TxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.defgateway_TxtBx2.TrailingIcon = null;
            this.defgateway_TxtBx2.UseSystemPasswordChar = false;
            this.defgateway_TxtBx2.ValidatingType = null;
            // 
            // subnetmask_TxtBx2
            // 
            this.subnetmask_TxtBx2.AllowPromptAsInput = true;
            this.subnetmask_TxtBx2.AnimateReadOnly = false;
            this.subnetmask_TxtBx2.AsciiOnly = false;
            this.subnetmask_TxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.subnetmask_TxtBx2.BeepOnError = false;
            this.subnetmask_TxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.subnetmask_TxtBx2.Depth = 0;
            this.subnetmask_TxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subnetmask_TxtBx2.HidePromptOnLeave = false;
            this.subnetmask_TxtBx2.HideSelection = true;
            this.subnetmask_TxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.subnetmask_TxtBx2.LeadingIcon = null;
            this.subnetmask_TxtBx2.Location = new System.Drawing.Point(379, 60);
            this.subnetmask_TxtBx2.Mask = "";
            this.subnetmask_TxtBx2.MaxLength = 32767;
            this.subnetmask_TxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.subnetmask_TxtBx2.Name = "subnetmask_TxtBx2";
            this.subnetmask_TxtBx2.PasswordChar = '\0';
            this.subnetmask_TxtBx2.PrefixSuffixText = null;
            this.subnetmask_TxtBx2.PromptChar = '_';
            this.subnetmask_TxtBx2.ReadOnly = false;
            this.subnetmask_TxtBx2.RejectInputOnFirstFailure = false;
            this.subnetmask_TxtBx2.ResetOnPrompt = true;
            this.subnetmask_TxtBx2.ResetOnSpace = true;
            this.subnetmask_TxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subnetmask_TxtBx2.SelectedText = "";
            this.subnetmask_TxtBx2.SelectionLength = 0;
            this.subnetmask_TxtBx2.SelectionStart = 0;
            this.subnetmask_TxtBx2.ShortcutsEnabled = true;
            this.subnetmask_TxtBx2.Size = new System.Drawing.Size(250, 48);
            this.subnetmask_TxtBx2.SkipLiterals = true;
            this.subnetmask_TxtBx2.TabIndex = 16;
            this.subnetmask_TxtBx2.TabStop = false;
            this.subnetmask_TxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.subnetmask_TxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.subnetmask_TxtBx2.TrailingIcon = null;
            this.subnetmask_TxtBx2.UseSystemPasswordChar = false;
            this.subnetmask_TxtBx2.ValidatingType = null;
            // 
            // ip_TxtBx2
            // 
            this.ip_TxtBx2.AllowPromptAsInput = true;
            this.ip_TxtBx2.AnimateReadOnly = false;
            this.ip_TxtBx2.AsciiOnly = false;
            this.ip_TxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ip_TxtBx2.BeepOnError = false;
            this.ip_TxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ip_TxtBx2.Depth = 0;
            this.ip_TxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ip_TxtBx2.HidePromptOnLeave = false;
            this.ip_TxtBx2.HideSelection = true;
            this.ip_TxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ip_TxtBx2.LeadingIcon = null;
            this.ip_TxtBx2.Location = new System.Drawing.Point(379, 6);
            this.ip_TxtBx2.Mask = "";
            this.ip_TxtBx2.MaxLength = 32767;
            this.ip_TxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.ip_TxtBx2.Name = "ip_TxtBx2";
            this.ip_TxtBx2.PasswordChar = '\0';
            this.ip_TxtBx2.PrefixSuffixText = null;
            this.ip_TxtBx2.PromptChar = '_';
            this.ip_TxtBx2.ReadOnly = false;
            this.ip_TxtBx2.RejectInputOnFirstFailure = false;
            this.ip_TxtBx2.ResetOnPrompt = true;
            this.ip_TxtBx2.ResetOnSpace = true;
            this.ip_TxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ip_TxtBx2.SelectedText = "";
            this.ip_TxtBx2.SelectionLength = 0;
            this.ip_TxtBx2.SelectionStart = 0;
            this.ip_TxtBx2.ShortcutsEnabled = true;
            this.ip_TxtBx2.Size = new System.Drawing.Size(250, 48);
            this.ip_TxtBx2.SkipLiterals = true;
            this.ip_TxtBx2.TabIndex = 15;
            this.ip_TxtBx2.TabStop = false;
            this.ip_TxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ip_TxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ip_TxtBx2.TrailingIcon = null;
            this.ip_TxtBx2.UseSystemPasswordChar = false;
            this.ip_TxtBx2.ValidatingType = null;
            // 
            // secdns_RichTxtBx2
            // 
            this.secdns_RichTxtBx2.AllowPromptAsInput = true;
            this.secdns_RichTxtBx2.AnimateReadOnly = false;
            this.secdns_RichTxtBx2.AsciiOnly = false;
            this.secdns_RichTxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.secdns_RichTxtBx2.BeepOnError = false;
            this.secdns_RichTxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.secdns_RichTxtBx2.Depth = 0;
            this.secdns_RichTxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.secdns_RichTxtBx2.HidePromptOnLeave = false;
            this.secdns_RichTxtBx2.HideSelection = true;
            this.secdns_RichTxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.secdns_RichTxtBx2.LeadingIcon = null;
            this.secdns_RichTxtBx2.Location = new System.Drawing.Point(6, 222);
            this.secdns_RichTxtBx2.Mask = "";
            this.secdns_RichTxtBx2.MaxLength = 32767;
            this.secdns_RichTxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.secdns_RichTxtBx2.Name = "secdns_RichTxtBx2";
            this.secdns_RichTxtBx2.PasswordChar = '\0';
            this.secdns_RichTxtBx2.PrefixSuffixText = null;
            this.secdns_RichTxtBx2.PromptChar = '_';
            this.secdns_RichTxtBx2.ReadOnly = true;
            this.secdns_RichTxtBx2.RejectInputOnFirstFailure = false;
            this.secdns_RichTxtBx2.ResetOnPrompt = true;
            this.secdns_RichTxtBx2.ResetOnSpace = true;
            this.secdns_RichTxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secdns_RichTxtBx2.SelectedText = "";
            this.secdns_RichTxtBx2.SelectionLength = 0;
            this.secdns_RichTxtBx2.SelectionStart = 0;
            this.secdns_RichTxtBx2.ShortcutsEnabled = true;
            this.secdns_RichTxtBx2.Size = new System.Drawing.Size(250, 48);
            this.secdns_RichTxtBx2.SkipLiterals = true;
            this.secdns_RichTxtBx2.TabIndex = 14;
            this.secdns_RichTxtBx2.TabStop = false;
            this.secdns_RichTxtBx2.Text = "Secondary DNS address";
            this.secdns_RichTxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.secdns_RichTxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.secdns_RichTxtBx2.TrailingIcon = null;
            this.secdns_RichTxtBx2.UseSystemPasswordChar = false;
            this.secdns_RichTxtBx2.ValidatingType = null;
            // 
            // primdns_RichTxtBx2
            // 
            this.primdns_RichTxtBx2.AllowPromptAsInput = true;
            this.primdns_RichTxtBx2.AnimateReadOnly = false;
            this.primdns_RichTxtBx2.AsciiOnly = false;
            this.primdns_RichTxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.primdns_RichTxtBx2.BeepOnError = false;
            this.primdns_RichTxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.primdns_RichTxtBx2.Depth = 0;
            this.primdns_RichTxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.primdns_RichTxtBx2.HidePromptOnLeave = false;
            this.primdns_RichTxtBx2.HideSelection = true;
            this.primdns_RichTxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.primdns_RichTxtBx2.LeadingIcon = null;
            this.primdns_RichTxtBx2.Location = new System.Drawing.Point(6, 168);
            this.primdns_RichTxtBx2.Mask = "";
            this.primdns_RichTxtBx2.MaxLength = 32767;
            this.primdns_RichTxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.primdns_RichTxtBx2.Name = "primdns_RichTxtBx2";
            this.primdns_RichTxtBx2.PasswordChar = '\0';
            this.primdns_RichTxtBx2.PrefixSuffixText = null;
            this.primdns_RichTxtBx2.PromptChar = '_';
            this.primdns_RichTxtBx2.ReadOnly = true;
            this.primdns_RichTxtBx2.RejectInputOnFirstFailure = false;
            this.primdns_RichTxtBx2.ResetOnPrompt = true;
            this.primdns_RichTxtBx2.ResetOnSpace = true;
            this.primdns_RichTxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.primdns_RichTxtBx2.SelectedText = "";
            this.primdns_RichTxtBx2.SelectionLength = 0;
            this.primdns_RichTxtBx2.SelectionStart = 0;
            this.primdns_RichTxtBx2.ShortcutsEnabled = true;
            this.primdns_RichTxtBx2.Size = new System.Drawing.Size(250, 48);
            this.primdns_RichTxtBx2.SkipLiterals = true;
            this.primdns_RichTxtBx2.TabIndex = 13;
            this.primdns_RichTxtBx2.TabStop = false;
            this.primdns_RichTxtBx2.Text = "Primary DNS address";
            this.primdns_RichTxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.primdns_RichTxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.primdns_RichTxtBx2.TrailingIcon = null;
            this.primdns_RichTxtBx2.UseSystemPasswordChar = false;
            this.primdns_RichTxtBx2.ValidatingType = null;
            // 
            // defgateway_RichTxtBx2
            // 
            this.defgateway_RichTxtBx2.AllowPromptAsInput = true;
            this.defgateway_RichTxtBx2.AnimateReadOnly = false;
            this.defgateway_RichTxtBx2.AsciiOnly = false;
            this.defgateway_RichTxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.defgateway_RichTxtBx2.BeepOnError = false;
            this.defgateway_RichTxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.defgateway_RichTxtBx2.Depth = 0;
            this.defgateway_RichTxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.defgateway_RichTxtBx2.HidePromptOnLeave = false;
            this.defgateway_RichTxtBx2.HideSelection = true;
            this.defgateway_RichTxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.defgateway_RichTxtBx2.LeadingIcon = null;
            this.defgateway_RichTxtBx2.Location = new System.Drawing.Point(6, 114);
            this.defgateway_RichTxtBx2.Mask = "";
            this.defgateway_RichTxtBx2.MaxLength = 32767;
            this.defgateway_RichTxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.defgateway_RichTxtBx2.Name = "defgateway_RichTxtBx2";
            this.defgateway_RichTxtBx2.PasswordChar = '\0';
            this.defgateway_RichTxtBx2.PrefixSuffixText = null;
            this.defgateway_RichTxtBx2.PromptChar = '_';
            this.defgateway_RichTxtBx2.ReadOnly = true;
            this.defgateway_RichTxtBx2.RejectInputOnFirstFailure = false;
            this.defgateway_RichTxtBx2.ResetOnPrompt = true;
            this.defgateway_RichTxtBx2.ResetOnSpace = true;
            this.defgateway_RichTxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.defgateway_RichTxtBx2.SelectedText = "";
            this.defgateway_RichTxtBx2.SelectionLength = 0;
            this.defgateway_RichTxtBx2.SelectionStart = 0;
            this.defgateway_RichTxtBx2.ShortcutsEnabled = true;
            this.defgateway_RichTxtBx2.Size = new System.Drawing.Size(250, 48);
            this.defgateway_RichTxtBx2.SkipLiterals = true;
            this.defgateway_RichTxtBx2.TabIndex = 12;
            this.defgateway_RichTxtBx2.TabStop = false;
            this.defgateway_RichTxtBx2.Text = "Default gateway";
            this.defgateway_RichTxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.defgateway_RichTxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.defgateway_RichTxtBx2.TrailingIcon = null;
            this.defgateway_RichTxtBx2.UseSystemPasswordChar = false;
            this.defgateway_RichTxtBx2.ValidatingType = null;
            // 
            // subnetmask_RichTxtBx2
            // 
            this.subnetmask_RichTxtBx2.AllowPromptAsInput = true;
            this.subnetmask_RichTxtBx2.AnimateReadOnly = false;
            this.subnetmask_RichTxtBx2.AsciiOnly = false;
            this.subnetmask_RichTxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.subnetmask_RichTxtBx2.BeepOnError = false;
            this.subnetmask_RichTxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.subnetmask_RichTxtBx2.Depth = 0;
            this.subnetmask_RichTxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subnetmask_RichTxtBx2.HidePromptOnLeave = false;
            this.subnetmask_RichTxtBx2.HideSelection = true;
            this.subnetmask_RichTxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.subnetmask_RichTxtBx2.LeadingIcon = null;
            this.subnetmask_RichTxtBx2.Location = new System.Drawing.Point(6, 60);
            this.subnetmask_RichTxtBx2.Mask = "";
            this.subnetmask_RichTxtBx2.MaxLength = 32767;
            this.subnetmask_RichTxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.subnetmask_RichTxtBx2.Name = "subnetmask_RichTxtBx2";
            this.subnetmask_RichTxtBx2.PasswordChar = '\0';
            this.subnetmask_RichTxtBx2.PrefixSuffixText = null;
            this.subnetmask_RichTxtBx2.PromptChar = '_';
            this.subnetmask_RichTxtBx2.ReadOnly = true;
            this.subnetmask_RichTxtBx2.RejectInputOnFirstFailure = false;
            this.subnetmask_RichTxtBx2.ResetOnPrompt = true;
            this.subnetmask_RichTxtBx2.ResetOnSpace = true;
            this.subnetmask_RichTxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subnetmask_RichTxtBx2.SelectedText = "";
            this.subnetmask_RichTxtBx2.SelectionLength = 0;
            this.subnetmask_RichTxtBx2.SelectionStart = 0;
            this.subnetmask_RichTxtBx2.ShortcutsEnabled = true;
            this.subnetmask_RichTxtBx2.Size = new System.Drawing.Size(250, 48);
            this.subnetmask_RichTxtBx2.SkipLiterals = true;
            this.subnetmask_RichTxtBx2.TabIndex = 11;
            this.subnetmask_RichTxtBx2.TabStop = false;
            this.subnetmask_RichTxtBx2.Text = "Subnet mask";
            this.subnetmask_RichTxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.subnetmask_RichTxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.subnetmask_RichTxtBx2.TrailingIcon = null;
            this.subnetmask_RichTxtBx2.UseSystemPasswordChar = false;
            this.subnetmask_RichTxtBx2.ValidatingType = null;
            // 
            // ip_RichTxtBx2
            // 
            this.ip_RichTxtBx2.AllowPromptAsInput = true;
            this.ip_RichTxtBx2.AnimateReadOnly = false;
            this.ip_RichTxtBx2.AsciiOnly = false;
            this.ip_RichTxtBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ip_RichTxtBx2.BeepOnError = false;
            this.ip_RichTxtBx2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ip_RichTxtBx2.Depth = 0;
            this.ip_RichTxtBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ip_RichTxtBx2.HidePromptOnLeave = false;
            this.ip_RichTxtBx2.HideSelection = true;
            this.ip_RichTxtBx2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.ip_RichTxtBx2.LeadingIcon = null;
            this.ip_RichTxtBx2.Location = new System.Drawing.Point(3, 6);
            this.ip_RichTxtBx2.Mask = "";
            this.ip_RichTxtBx2.MaxLength = 32767;
            this.ip_RichTxtBx2.MouseState = MaterialSkin.MouseState.OUT;
            this.ip_RichTxtBx2.Name = "ip_RichTxtBx2";
            this.ip_RichTxtBx2.PasswordChar = '\0';
            this.ip_RichTxtBx2.PrefixSuffixText = null;
            this.ip_RichTxtBx2.PromptChar = '_';
            this.ip_RichTxtBx2.ReadOnly = true;
            this.ip_RichTxtBx2.RejectInputOnFirstFailure = false;
            this.ip_RichTxtBx2.ResetOnPrompt = true;
            this.ip_RichTxtBx2.ResetOnSpace = true;
            this.ip_RichTxtBx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ip_RichTxtBx2.SelectedText = "";
            this.ip_RichTxtBx2.SelectionLength = 0;
            this.ip_RichTxtBx2.SelectionStart = 0;
            this.ip_RichTxtBx2.ShortcutsEnabled = true;
            this.ip_RichTxtBx2.Size = new System.Drawing.Size(250, 48);
            this.ip_RichTxtBx2.SkipLiterals = true;
            this.ip_RichTxtBx2.TabIndex = 10;
            this.ip_RichTxtBx2.TabStop = false;
            this.ip_RichTxtBx2.Text = "IP Address";
            this.ip_RichTxtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ip_RichTxtBx2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.ip_RichTxtBx2.TrailingIcon = null;
            this.ip_RichTxtBx2.UseSystemPasswordChar = false;
            this.ip_RichTxtBx2.ValidatingType = null;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(653, 495);
            this.Controls.Add(this.nuts_tabCtrl);
            this.Controls.Add(this.nuts_tabSlctr);
            this.Controls.Add(this.nuts_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.nuts_menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(653, 495);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(653, 495);
            this.Name = "MainForm";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NUTs - Network Utility Tools";
            this.nuts_menu.ResumeLayout(false);
            this.nuts_menu.PerformLayout();
            this.nuts_tabCtrl.ResumeLayout(false);
            this.netsettings_tabCtrl.ResumeLayout(false);
            this.changenetsettings_tabCtrl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip nuts_menu;
        private ToolStripMenuItem languages_menuItem;
        private ToolStripMenuItem switchtoen_btn;
        private ToolStripMenuItem switchtofr_btn;
        private ToolStripMenuItem themes_menuItem;
        private ToolStripMenuItem lTheme_btn;
        private ToolStripMenuItem dTheme_btn;
        private MaterialSkin.Controls.MaterialTabSelector nuts_tabSlctr;
        private MaterialSkin.Controls.MaterialTabControl nuts_tabCtrl;
        private TabPage netsettings_tabCtrl;
        private MaterialSkin.Controls.MaterialButton retrieve_btn;
        private MaterialSkin.Controls.MaterialMaskedTextBox secdns_TxtBx1;
        private MaterialSkin.Controls.MaterialMaskedTextBox primdns_TxtBx1;
        private MaterialSkin.Controls.MaterialMaskedTextBox defgateway_TxtBx1;
        private MaterialSkin.Controls.MaterialMaskedTextBox subnetmask_TxtBx1;
        private MaterialSkin.Controls.MaterialMaskedTextBox ip_TxtBx1;
        private MaterialSkin.Controls.MaterialMaskedTextBox secdns_RichTxtBx1;
        private MaterialSkin.Controls.MaterialMaskedTextBox primdns_RichTxtBx1;
        private MaterialSkin.Controls.MaterialMaskedTextBox defgateway_RichTxtBx1;
        private MaterialSkin.Controls.MaterialMaskedTextBox subnetmask_RichTxtBx1;
        private MaterialSkin.Controls.MaterialMaskedTextBox ip_RichTxtBx1;
        private TabPage changenetsettings_tabCtrl;
        private MaterialSkin.Controls.MaterialButton static_btn;
        private MaterialSkin.Controls.MaterialButton dhcp_btn;
        private MaterialSkin.Controls.MaterialMaskedTextBox secdns_TxtBx2;
        private MaterialSkin.Controls.MaterialMaskedTextBox primdns_TxtBx2;
        private MaterialSkin.Controls.MaterialMaskedTextBox defgateway_TxtBx2;
        private MaterialSkin.Controls.MaterialMaskedTextBox subnetmask_TxtBx2;
        private MaterialSkin.Controls.MaterialMaskedTextBox ip_TxtBx2;
        private MaterialSkin.Controls.MaterialMaskedTextBox secdns_RichTxtBx2;
        private MaterialSkin.Controls.MaterialMaskedTextBox primdns_RichTxtBx2;
        private MaterialSkin.Controls.MaterialMaskedTextBox defgateway_RichTxtBx2;
        private MaterialSkin.Controls.MaterialMaskedTextBox subnetmask_RichTxtBx2;
        private MaterialSkin.Controls.MaterialMaskedTextBox ip_RichTxtBx2;
    }
}