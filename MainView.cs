using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Geometry3d;
namespace AutoCADToTeklaConversion
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void ConvertModel_Click(object sender, EventArgs e)
        {
            if (LocalHelpers.LocalHelpers.CheckConnectionWithTekla())
            {
                MessageBox.Show("Connected to Tekla. Ready for conversion");

                Point startPoint = new Point(8296789.6, 4473080.9, 116900.0);
                Point endPoint = new Point(8296789.6, 4473080.9, 117400.0);
              //  LocalHelpers.LocalHelpers.ConvertBeamColumn(startPoint,endPoint, "D270", "M30");




                //2nd ismc 
                 startPoint = new Point(8297189.7, 4474046.6, 117117.0);
                 endPoint = new Point(8297673.5, 4472106.3, 117117.0);
                LocalHelpers.LocalHelpers.ConvertBeamColumn( endPoint,startPoint, "ISMC150", "E250 BR/B0");



                //handrail 

                startPoint = new Point(8299799.5 , 4471789.8,118150.0) ;
                endPoint = new Point(8296210.5 ,4473492.9,118150.0);
                LocalHelpers.LocalHelpers.ConvertBeamColumn(startPoint, endPoint, "32NB (M)", "Yst 310");

              //  LocalHelpers.LocalHelpers.CreatePolyBeam(startPoint, endPoint, "32NB (M)", "Yst 310");



                startPoint = new Point(7296705.2, 4473186.2, 117150.0 );
                endPoint = new Point(8296816.6, 4473213.1, 117150.0);
                LocalHelpers.LocalHelpers.ConvertToePlate(startPoint, endPoint, "PLT50*6", "E250 BR/B0");
                
                // toe angle
                startPoint = new Point(8296011.2, 5573247.7, 117117.0);
                endPoint = new Point(8298658.5, 4473868.2, 117117.0);
                LocalHelpers.LocalHelpers.CreateToeAngle(endPoint,startPoint, "ISA100X100X8", "E250 BR/B0");
            }
            else
            {
                MessageBox.Show("Not Connected to Tekla!!!!!!!!!!!!!!");
               
            }
        }

    }
}
