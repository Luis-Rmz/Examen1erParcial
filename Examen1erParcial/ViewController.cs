using System;
using Foundation;
using UIKit;

namespace Examen1erParcial
{
    public partial class ViewController : UIViewController
    {

        NSUserDefaults userDefault = NSUserDefaults.StandardUserDefaults;
        NSObject didChangeNOtificationToken;


        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            View.BackgroundColor = UIColor.Clear;
            var NMode = userDefault.BoolForKey("NM");
            Console.WriteLine((NMode));

            Slider.ValueChanged += Slider_ValueChanged;
            btnCalcu.TouchUpInside += BtnCalcu_TouchUpInside;


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            didChangeNOtificationToken = NSNotificationCenter.DefaultCenter.AddObserver(NSUserDefaults.DidChangeNotification, SC);
        }


        public override void ViewWillDisappear(bool animated)
        {
            
        }

        void SC(NSNotification obj)
        {
            var isNM = userDefault.BoolForKey("NM");
            if (isNM)
            {
                View.BackgroundColor = UIColor.DarkGray;
                txtNumero1.TextColor = UIColor.DarkGray;
                txtNumero2.TextColor = UIColor.DarkGray;
                txtResultado.TextColor = UIColor.White;

                uno.TextColor = UIColor.White;
                dos.TextColor = UIColor.White;
                tres.TextColor = UIColor.White;
                mas.TextColor = UIColor.White;
                menos.TextColor = UIColor.White;
                por.TextColor = UIColor.White;
                entre.TextColor = UIColor.White;
                txtNumero1.KeyboardAppearance = UIKeyboardAppearance.Dark;
                txtNumero2.KeyboardAppearance = UIKeyboardAppearance.Dark;
                UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;
            }
            else
            {
                View.BackgroundColor = UIColor.White;
                txtNumero1.BackgroundColor = UIColor.White;
                txtNumero2.BackgroundColor = UIColor.White;
                txtResultado.TextColor = UIColor.Black;

                uno.TextColor = UIColor.Black;
                dos.TextColor = UIColor.Black;
                tres.TextColor = UIColor.Black;
                mas.TextColor = UIColor.Black;
                menos.TextColor = UIColor.Black;
                por.TextColor = UIColor.Black;
                entre.TextColor = UIColor.Black;
                txtNumero1.KeyboardAppearance = UIKeyboardAppearance.Light;
                txtNumero2.KeyboardAppearance = UIKeyboardAppearance.Light;
                UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.Default;
            }

        }

        void Slider_ValueChanged(object sender, EventArgs e)
        {
            float validacion = (float)Math.Round(Slider.Value);
            Slider.SetValue(validacion, true);
        }

        void BtnCalcu_TouchUpInside(object sender, EventArgs e)
        {

            if ((int)Slider.Value == 0)
            {
                //double n1 = double.Parse(txtNumero1.Text);
                //double n2 = double.Parse(txtNumero2.Text);

                if (double.TryParse(txtNumero1.Text,out double res)&& double.TryParse(txtNumero2.Text,out double res2))
                {
                    Clases.Operaciones op = new Clases.Operaciones(res, res2);
                    txtResultado.Text = op.Suma(res, res2).ToString();
                }
                //if(double.TryParse(txtNumero1))
                else
                {
                    txtResultado.Text = "Ingresa un dato válido";
                }


            }
            else if ((int)Slider.Value == 1)
            {
                //double n1 = double.Parse(txtNumero1.Text);
                //double n2 = double.Parse(txtNumero2.Text);
                if (double.TryParse(txtNumero1.Text, out double res) && double.TryParse(txtNumero2.Text, out double res2))
                {
                    Clases.Operaciones op = new Clases.Operaciones(res, res2);
                    txtResultado.Text = op.Resta(res, res2).ToString();
                }

                else
                {
                    txtResultado.Text = "Ingresa un dato válido";
                }

            }
            else if ((int)Slider.Value == 2)
            {
                //double n1 = double.Parse(txtNumero1.Text);
                //double n2 = double.Parse(txtNumero2.Text);
                if (double.TryParse(txtNumero1.Text, out double res) && double.TryParse(txtNumero2.Text, out double res2))
                {
                    Clases.Operaciones op = new Clases.Operaciones(res, res2);
                    txtResultado.Text = op.Multiplicacion(res, res2).ToString();
                }
                else
                {
                    txtResultado.Text = "Ingresa un dato válido";
                }
               
            }

            else if ((int)Slider.Value == 3)
            {
                //double n1 = double.Parse(txtNumero1.Text);
                //double n2 = double.Parse(txtNumero2.Text);
                if (double.TryParse(txtNumero1.Text, out double res) && double.TryParse(txtNumero2.Text, out double res2))
                {
                    Clases.Operaciones op = new Clases.Operaciones(res, res2);
                    txtResultado.Text = op.Division(res, res2).ToString();
                }
                else
                {
                    txtResultado.Text = "Ingresa un dato válido";
                }
            }

        }
    }
}
