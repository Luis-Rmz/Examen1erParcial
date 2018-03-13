// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Examen1erParcial
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnCalcu { get; set; }

		[Outlet]
		UIKit.UILabel dos { get; set; }

		[Outlet]
		UIKit.UILabel entre { get; set; }

		[Outlet]
		UIKit.UILabel mas { get; set; }

		[Outlet]
		UIKit.UILabel menos { get; set; }

		[Outlet]
		UIKit.UILabel por { get; set; }

		[Outlet]
		UIKit.UISlider Slider { get; set; }

		[Outlet]
		UIKit.UILabel tres { get; set; }

		[Outlet]
		UIKit.UITextField txtNumero1 { get; set; }

		[Outlet]
		UIKit.UITextField txtNumero2 { get; set; }

		[Outlet]
		UIKit.UILabel txtResultado { get; set; }

		[Outlet]
		UIKit.UILabel uno { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (dos != null) {
				dos.Dispose ();
				dos = null;
			}

			if (entre != null) {
				entre.Dispose ();
				entre = null;
			}

			if (mas != null) {
				mas.Dispose ();
				mas = null;
			}

			if (menos != null) {
				menos.Dispose ();
				menos = null;
			}

			if (por != null) {
				por.Dispose ();
				por = null;
			}

			if (Slider != null) {
				Slider.Dispose ();
				Slider = null;
			}

			if (tres != null) {
				tres.Dispose ();
				tres = null;
			}

			if (txtNumero1 != null) {
				txtNumero1.Dispose ();
				txtNumero1 = null;
			}

			if (txtNumero2 != null) {
				txtNumero2.Dispose ();
				txtNumero2 = null;
			}

			if (txtResultado != null) {
				txtResultado.Dispose ();
				txtResultado = null;
			}

			if (uno != null) {
				uno.Dispose ();
				uno = null;
			}

			if (btnCalcu != null) {
				btnCalcu.Dispose ();
				btnCalcu = null;
			}
		}
	}
}
