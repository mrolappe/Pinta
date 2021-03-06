// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Pinta {
    
    
    public partial class LevelsDialog {
        
        private Gtk.HBox hbox1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label labelInputHist;
        
        private Gtk.HSeparator hseparator1;
        
        private Pinta.HistogramWidget histogramInput;
        
        private Gtk.VBox vbox3;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Label labelInput;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.HBox hbox8;
        
        private Gtk.VBox vboxInputSpin;
        
        private Gtk.SpinButton spinInHigh;
        
        private Pinta.ColorPanelWidget colorpanelInHigh;
        
        private Gtk.Alignment alignment1;
        
        private Pinta.ColorPanelWidget colorpanelInLow;
        
        private Gtk.SpinButton spinInLow;
        
        private Pinta.ColorGradientWidget gradientInput;
        
        private Gtk.VBox vbox4;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label labelOutput;
        
        private Gtk.HSeparator hseparator3;
        
        private Gtk.HBox hbox9;
        
        private Pinta.ColorGradientWidget gradientOutput;
        
        private Gtk.VBox vboxOutputSpin;
        
        private Gtk.SpinButton spinOutHigh;
        
        private Pinta.ColorPanelWidget colorpanelOutHigh;
        
        private Gtk.SpinButton spinOutGamma;
        
        private Pinta.ColorPanelWidget colorpanelOutMid;
        
        private Pinta.ColorPanelWidget colorpanelOutLow;
        
        private Gtk.SpinButton spinOutLow;
        
        private Gtk.VBox vbox5;
        
        private Gtk.HBox hbox5;
        
        private Gtk.Label labelOutputHist;
        
        private Gtk.HSeparator hseparator4;
        
        private Pinta.HistogramWidget histogramOutput;
        
        private Gtk.HBox hboxBottom;
        
        private Gtk.Button buttonAuto;
        
        private Gtk.Button buttonReset;
        
        private Gtk.CheckButton checkRed;
        
        private Gtk.CheckButton checkGreen;
        
        private Gtk.Button buttonOk;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.CheckButton checkBlue;
        
        private Gtk.Button buttonDummy;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Pinta.LevelsDialog
            this.Events = ((Gdk.EventMask)(260));
            this.Name = "Pinta.LevelsDialog";
            this.Title = Mono.Unix.Catalog.GetString("Levels Adjustment");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Resizable = false;
            this.AllowGrow = false;
            this.SkipTaskbarHint = true;
            // Internal child Pinta.LevelsDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(1534));
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Events = ((Gdk.EventMask)(260));
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.labelInputHist = new Gtk.Label();
            this.labelInputHist.Name = "labelInputHist";
            this.labelInputHist.LabelProp = Mono.Unix.Catalog.GetString("Input Histogram");
            this.hbox2.Add(this.labelInputHist);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox2[this.labelInputHist]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.hseparator1 = new Gtk.HSeparator();
            this.hseparator1.Name = "hseparator1";
            this.hbox2.Add(this.hseparator1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox2[this.hseparator1]));
            w3.Position = 1;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.histogramInput = new Pinta.HistogramWidget();
            this.histogramInput.WidthRequest = 130;
            this.histogramInput.Events = ((Gdk.EventMask)(256));
            this.histogramInput.Name = "histogramInput";
            this.histogramInput.FlipHorizontal = true;
            this.histogramInput.FlipVertical = false;
            this.vbox2.Add(this.histogramInput);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox2[this.histogramInput]));
            w5.Position = 1;
            this.hbox1.Add(this.vbox2);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
            w6.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Events = ((Gdk.EventMask)(36));
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.labelInput = new Gtk.Label();
            this.labelInput.Name = "labelInput";
            this.labelInput.LabelProp = Mono.Unix.Catalog.GetString("Input");
            this.hbox3.Add(this.labelInput);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox3[this.labelInput]));
            w7.Position = 0;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.hbox3.Add(this.hseparator2);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox3[this.hseparator2]));
            w8.Position = 1;
            this.vbox3.Add(this.hbox3);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox8 = new Gtk.HBox();
            this.hbox8.Events = ((Gdk.EventMask)(260));
            this.hbox8.Name = "hbox8";
            this.hbox8.Spacing = 6;
            // Container child hbox8.Gtk.Box+BoxChild
            this.vboxInputSpin = new Gtk.VBox();
            this.vboxInputSpin.Name = "vboxInputSpin";
            this.vboxInputSpin.Spacing = 6;
            // Container child vboxInputSpin.Gtk.Box+BoxChild
            this.spinInHigh = new Gtk.SpinButton(1, 255, 1);
            this.spinInHigh.CanFocus = true;
            this.spinInHigh.Name = "spinInHigh";
            this.spinInHigh.Adjustment.PageIncrement = 10;
            this.spinInHigh.ClimbRate = 1;
            this.spinInHigh.Numeric = true;
            this.spinInHigh.Value = 255;
            this.vboxInputSpin.Add(this.spinInHigh);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vboxInputSpin[this.spinInHigh]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vboxInputSpin.Gtk.Box+BoxChild
            this.colorpanelInHigh = new Pinta.ColorPanelWidget();
            this.colorpanelInHigh.HeightRequest = 24;
            this.colorpanelInHigh.Events = ((Gdk.EventMask)(256));
            this.colorpanelInHigh.Name = "colorpanelInHigh";
            this.vboxInputSpin.Add(this.colorpanelInHigh);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vboxInputSpin[this.colorpanelInHigh]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            // Container child vboxInputSpin.Gtk.Box+BoxChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            this.vboxInputSpin.Add(this.alignment1);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vboxInputSpin[this.alignment1]));
            w12.Position = 2;
            // Container child vboxInputSpin.Gtk.Box+BoxChild
            this.colorpanelInLow = new Pinta.ColorPanelWidget();
            this.colorpanelInLow.HeightRequest = 24;
            this.colorpanelInLow.Events = ((Gdk.EventMask)(256));
            this.colorpanelInLow.Name = "colorpanelInLow";
            this.vboxInputSpin.Add(this.colorpanelInLow);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vboxInputSpin[this.colorpanelInLow]));
            w13.Position = 3;
            w13.Expand = false;
            w13.Fill = false;
            // Container child vboxInputSpin.Gtk.Box+BoxChild
            this.spinInLow = new Gtk.SpinButton(0, 254, 1);
            this.spinInLow.CanFocus = true;
            this.spinInLow.Name = "spinInLow";
            this.spinInLow.Adjustment.PageIncrement = 10;
            this.spinInLow.ClimbRate = 1;
            this.spinInLow.Numeric = true;
            this.vboxInputSpin.Add(this.spinInLow);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vboxInputSpin[this.spinInLow]));
            w14.Position = 4;
            w14.Expand = false;
            w14.Fill = false;
            this.hbox8.Add(this.vboxInputSpin);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox8[this.vboxInputSpin]));
            w15.Position = 0;
            w15.Expand = false;
            w15.Fill = false;
            // Container child hbox8.Gtk.Box+BoxChild
            this.gradientInput = new Pinta.ColorGradientWidget();
            this.gradientInput.WidthRequest = 40;
            this.gradientInput.CanFocus = true;
            this.gradientInput.Events = ((Gdk.EventMask)(510));
            this.gradientInput.ExtensionEvents = ((Gdk.ExtensionMode)(1));
            this.gradientInput.Name = "gradientInput";
            this.gradientInput.Count = 2;
            this.hbox8.Add(this.gradientInput);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.hbox8[this.gradientInput]));
            w16.Position = 1;
            w16.Expand = false;
            w16.Fill = false;
            this.vbox3.Add(this.hbox8);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox8]));
            w17.Position = 1;
            this.hbox1.Add(this.vbox3);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox3]));
            w18.Position = 1;
            w18.Expand = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.labelOutput = new Gtk.Label();
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.LabelProp = Mono.Unix.Catalog.GetString("Output");
            this.hbox4.Add(this.labelOutput);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.hbox4[this.labelOutput]));
            w19.Position = 0;
            w19.Expand = false;
            w19.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.hseparator3 = new Gtk.HSeparator();
            this.hseparator3.Name = "hseparator3";
            this.hbox4.Add(this.hseparator3);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox4[this.hseparator3]));
            w20.Position = 1;
            this.vbox4.Add(this.hbox4);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.vbox4[this.hbox4]));
            w21.Position = 0;
            w21.Expand = false;
            w21.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox9 = new Gtk.HBox();
            this.hbox9.Name = "hbox9";
            this.hbox9.Spacing = 6;
            // Container child hbox9.Gtk.Box+BoxChild
            this.gradientOutput = new Pinta.ColorGradientWidget();
            this.gradientOutput.WidthRequest = 40;
            this.gradientOutput.Events = ((Gdk.EventMask)(256));
            this.gradientOutput.Name = "gradientOutput";
            this.gradientOutput.Count = 3;
            this.hbox9.Add(this.gradientOutput);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.hbox9[this.gradientOutput]));
            w22.Position = 1;
            w22.Expand = false;
            w22.Fill = false;
            // Container child hbox9.Gtk.Box+BoxChild
            this.vboxOutputSpin = new Gtk.VBox();
            this.vboxOutputSpin.Name = "vboxOutputSpin";
            this.vboxOutputSpin.Spacing = 6;
            // Container child vboxOutputSpin.Gtk.Box+BoxChild
            this.spinOutHigh = new Gtk.SpinButton(2, 255, 1);
            this.spinOutHigh.CanFocus = true;
            this.spinOutHigh.Name = "spinOutHigh";
            this.spinOutHigh.Adjustment.PageIncrement = 10;
            this.spinOutHigh.ClimbRate = 1;
            this.spinOutHigh.Numeric = true;
            this.spinOutHigh.Value = 255;
            this.vboxOutputSpin.Add(this.spinOutHigh);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.vboxOutputSpin[this.spinOutHigh]));
            w23.Position = 0;
            w23.Expand = false;
            w23.Fill = false;
            // Container child vboxOutputSpin.Gtk.Box+BoxChild
            this.colorpanelOutHigh = new Pinta.ColorPanelWidget();
            this.colorpanelOutHigh.HeightRequest = 24;
            this.colorpanelOutHigh.Events = ((Gdk.EventMask)(256));
            this.colorpanelOutHigh.Name = "colorpanelOutHigh";
            this.vboxOutputSpin.Add(this.colorpanelOutHigh);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vboxOutputSpin[this.colorpanelOutHigh]));
            w24.Position = 1;
            w24.Expand = false;
            w24.Fill = false;
            // Container child vboxOutputSpin.Gtk.Box+BoxChild
            this.spinOutGamma = new Gtk.SpinButton(0, 100, 1);
            this.spinOutGamma.CanFocus = true;
            this.spinOutGamma.Name = "spinOutGamma";
            this.spinOutGamma.Adjustment.PageIncrement = 10;
            this.spinOutGamma.ClimbRate = 1;
            this.spinOutGamma.Numeric = true;
            this.spinOutGamma.Value = 1;
            this.vboxOutputSpin.Add(this.spinOutGamma);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vboxOutputSpin[this.spinOutGamma]));
            w25.Position = 2;
            w25.Expand = false;
            w25.Fill = false;
            // Container child vboxOutputSpin.Gtk.Box+BoxChild
            this.colorpanelOutMid = new Pinta.ColorPanelWidget();
            this.colorpanelOutMid.HeightRequest = 24;
            this.colorpanelOutMid.Events = ((Gdk.EventMask)(256));
            this.colorpanelOutMid.Name = "colorpanelOutMid";
            this.vboxOutputSpin.Add(this.colorpanelOutMid);
            Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.vboxOutputSpin[this.colorpanelOutMid]));
            w26.Position = 3;
            w26.Expand = false;
            w26.Fill = false;
            // Container child vboxOutputSpin.Gtk.Box+BoxChild
            this.colorpanelOutLow = new Pinta.ColorPanelWidget();
            this.colorpanelOutLow.HeightRequest = 24;
            this.colorpanelOutLow.Events = ((Gdk.EventMask)(256));
            this.colorpanelOutLow.Name = "colorpanelOutLow";
            this.vboxOutputSpin.Add(this.colorpanelOutLow);
            Gtk.Box.BoxChild w27 = ((Gtk.Box.BoxChild)(this.vboxOutputSpin[this.colorpanelOutLow]));
            w27.Position = 4;
            w27.Expand = false;
            w27.Fill = false;
            // Container child vboxOutputSpin.Gtk.Box+BoxChild
            this.spinOutLow = new Gtk.SpinButton(0, 252, 1);
            this.spinOutLow.CanFocus = true;
            this.spinOutLow.Name = "spinOutLow";
            this.spinOutLow.Adjustment.PageIncrement = 10;
            this.spinOutLow.ClimbRate = 1;
            this.spinOutLow.Numeric = true;
            this.vboxOutputSpin.Add(this.spinOutLow);
            Gtk.Box.BoxChild w28 = ((Gtk.Box.BoxChild)(this.vboxOutputSpin[this.spinOutLow]));
            w28.Position = 5;
            w28.Expand = false;
            w28.Fill = false;
            this.hbox9.Add(this.vboxOutputSpin);
            Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.hbox9[this.vboxOutputSpin]));
            w29.Position = 2;
            w29.Expand = false;
            w29.Fill = false;
            this.vbox4.Add(this.hbox9);
            Gtk.Box.BoxChild w30 = ((Gtk.Box.BoxChild)(this.vbox4[this.hbox9]));
            w30.Position = 1;
            this.hbox1.Add(this.vbox4);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox4]));
            w31.Position = 2;
            w31.Expand = false;
            w31.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.labelOutputHist = new Gtk.Label();
            this.labelOutputHist.Name = "labelOutputHist";
            this.labelOutputHist.LabelProp = Mono.Unix.Catalog.GetString("Output Histogram");
            this.hbox5.Add(this.labelOutputHist);
            Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(this.hbox5[this.labelOutputHist]));
            w32.Position = 0;
            w32.Expand = false;
            w32.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            this.hseparator4 = new Gtk.HSeparator();
            this.hseparator4.Name = "hseparator4";
            this.hbox5.Add(this.hseparator4);
            Gtk.Box.BoxChild w33 = ((Gtk.Box.BoxChild)(this.hbox5[this.hseparator4]));
            w33.Position = 1;
            this.vbox5.Add(this.hbox5);
            Gtk.Box.BoxChild w34 = ((Gtk.Box.BoxChild)(this.vbox5[this.hbox5]));
            w34.Position = 0;
            w34.Expand = false;
            w34.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.histogramOutput = new Pinta.HistogramWidget();
            this.histogramOutput.WidthRequest = 130;
            this.histogramOutput.Events = ((Gdk.EventMask)(256));
            this.histogramOutput.Name = "histogramOutput";
            this.histogramOutput.FlipHorizontal = false;
            this.histogramOutput.FlipVertical = false;
            this.vbox5.Add(this.histogramOutput);
            Gtk.Box.BoxChild w35 = ((Gtk.Box.BoxChild)(this.vbox5[this.histogramOutput]));
            w35.Position = 1;
            this.hbox1.Add(this.vbox5);
            Gtk.Box.BoxChild w36 = ((Gtk.Box.BoxChild)(this.hbox1[this.vbox5]));
            w36.Position = 3;
            w1.Add(this.hbox1);
            Gtk.Box.BoxChild w37 = ((Gtk.Box.BoxChild)(w1[this.hbox1]));
            w37.Position = 0;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hboxBottom = new Gtk.HBox();
            this.hboxBottom.Name = "hboxBottom";
            this.hboxBottom.Spacing = 6;
            // Container child hboxBottom.Gtk.Box+BoxChild
            this.buttonAuto = new Gtk.Button();
            this.buttonAuto.WidthRequest = 80;
            this.buttonAuto.CanFocus = true;
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.UseUnderline = true;
            this.buttonAuto.Label = Mono.Unix.Catalog.GetString("Auto");
            this.hboxBottom.Add(this.buttonAuto);
            Gtk.Box.BoxChild w38 = ((Gtk.Box.BoxChild)(this.hboxBottom[this.buttonAuto]));
            w38.Position = 0;
            w38.Expand = false;
            w38.Fill = false;
            // Container child hboxBottom.Gtk.Box+BoxChild
            this.buttonReset = new Gtk.Button();
            this.buttonReset.WidthRequest = 80;
            this.buttonReset.CanFocus = true;
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.UseUnderline = true;
            this.buttonReset.Label = Mono.Unix.Catalog.GetString("Reset");
            this.hboxBottom.Add(this.buttonReset);
            Gtk.Box.BoxChild w39 = ((Gtk.Box.BoxChild)(this.hboxBottom[this.buttonReset]));
            w39.Position = 1;
            w39.Expand = false;
            w39.Fill = false;
            // Container child hboxBottom.Gtk.Box+BoxChild
            this.checkRed = new Gtk.CheckButton();
            this.checkRed.CanFocus = true;
            this.checkRed.Name = "checkRed";
            this.checkRed.Label = Mono.Unix.Catalog.GetString("Red");
            this.checkRed.Active = true;
            this.checkRed.DrawIndicator = true;
            this.checkRed.UseUnderline = true;
            this.hboxBottom.Add(this.checkRed);
            Gtk.Box.BoxChild w40 = ((Gtk.Box.BoxChild)(this.hboxBottom[this.checkRed]));
            w40.Position = 2;
            // Container child hboxBottom.Gtk.Box+BoxChild
            this.checkGreen = new Gtk.CheckButton();
            this.checkGreen.CanFocus = true;
            this.checkGreen.Name = "checkGreen";
            this.checkGreen.Label = Mono.Unix.Catalog.GetString("Green");
            this.checkGreen.Active = true;
            this.checkGreen.DrawIndicator = true;
            this.checkGreen.UseUnderline = true;
            this.hboxBottom.Add(this.checkGreen);
            Gtk.Box.BoxChild w41 = ((Gtk.Box.BoxChild)(this.hboxBottom[this.checkGreen]));
            w41.Position = 3;
            // Container child hboxBottom.Gtk.Box+BoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.WidthRequest = 80;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.hboxBottom.Add(this.buttonOk);
            Gtk.Box.BoxChild w42 = ((Gtk.Box.BoxChild)(this.hboxBottom[this.buttonOk]));
            w42.PackType = ((Gtk.PackType)(1));
            w42.Position = 4;
            w42.Expand = false;
            w42.Fill = false;
            // Container child hboxBottom.Gtk.Box+BoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.WidthRequest = 80;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.hboxBottom.Add(this.buttonCancel);
            Gtk.Box.BoxChild w43 = ((Gtk.Box.BoxChild)(this.hboxBottom[this.buttonCancel]));
            w43.PackType = ((Gtk.PackType)(1));
            w43.Position = 5;
            w43.Expand = false;
            w43.Fill = false;
            // Container child hboxBottom.Gtk.Box+BoxChild
            this.checkBlue = new Gtk.CheckButton();
            this.checkBlue.CanFocus = true;
            this.checkBlue.Name = "checkBlue";
            this.checkBlue.Label = Mono.Unix.Catalog.GetString("Blue");
            this.checkBlue.Active = true;
            this.checkBlue.DrawIndicator = true;
            this.checkBlue.UseUnderline = true;
            this.hboxBottom.Add(this.checkBlue);
            Gtk.Box.BoxChild w44 = ((Gtk.Box.BoxChild)(this.hboxBottom[this.checkBlue]));
            w44.PackType = ((Gtk.PackType)(1));
            w44.Position = 6;
            w1.Add(this.hboxBottom);
            Gtk.Box.BoxChild w45 = ((Gtk.Box.BoxChild)(w1[this.hboxBottom]));
            w45.PackType = ((Gtk.PackType)(1));
            w45.Position = 4;
            w45.Expand = false;
            w45.Fill = false;
            // Internal child Pinta.LevelsDialog.ActionArea
            Gtk.HButtonBox w46 = this.ActionArea;
            w46.Name = "__gtksharp_58_Stetic_TopLevelDialog_ActionArea";
            w46.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child __gtksharp_58_Stetic_TopLevelDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonDummy = new Gtk.Button();
            this.buttonDummy.Sensitive = false;
            this.buttonDummy.CanFocus = true;
            this.buttonDummy.Name = "buttonDummy";
            this.buttonDummy.UseUnderline = true;
            this.buttonDummy.Label = Mono.Unix.Catalog.GetString("In stetic action button box cannot be empty");
            this.AddActionWidget(this.buttonDummy, -5);
            Gtk.ButtonBox.ButtonBoxChild w47 = ((Gtk.ButtonBox.ButtonBoxChild)(w46[this.buttonDummy]));
            w47.Expand = false;
            w47.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 1754;
            this.DefaultHeight = 326;
            this.buttonDummy.Hide();
            this.Show();
        }
    }
}
