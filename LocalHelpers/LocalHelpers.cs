using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using System.Collections;

namespace AutoCADToTeklaConversion.LocalHelpers
{
    public static class LocalHelpers
    {
        // Get Connection Status with Tekla
        public static Model model;
        public static bool CheckConnectionWithTekla()
        {
            

            model = new Tekla.Structures.Model.Model();

            if (model.GetConnectionStatus())
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        public static void ConvertBeamColumn(Point startPoint, Point endPoint, string profileString, string materialString)
        {
            
            Beam beam = new Beam(startPoint,endPoint); // Define the start and end points of the beam.
            beam.Name = "COLUMN";
            beam.Profile.ProfileString = profileString; // Set the beam profile to HEA300.
            beam.Material.MaterialString = materialString; // Set the beam material to S235.
            
            beam.Position.Plane = Position.PlaneEnum.LEFT;
            beam.Insert(); // Insert the beam into the model.
           
            model.CommitChanges();
        }

        public static void ConvertLadder()
        {

        }
        public static void ConvertToePlate(Point startPoint, Point endPoint, string profileString, string materialString)
        {
            Beam beam = new Beam(startPoint, endPoint);
            
            beam.Name = "TOE PLATE";
            beam.Profile.ProfileString = profileString; // Set the beam profile to HEA300.
            beam.Material.MaterialString = materialString; // Set the beam material to S235.
            beam.Insert(); // Insert the beam into the model.
            model.CommitChanges();
        }

        public static void CreateACounterPlate()
        {
            ContourPoint point = new ContourPoint(new Point(8296705.2, 4473186.2, 117150.0), null);
            ContourPoint point2 = new ContourPoint(new Point(8996705.2, 4473186.2, 117150.0), null);
            ContourPoint point3 = new ContourPoint(new Point(8996705.2, 4983186.2, 117150.0), null);

            ContourPlate CP = new ContourPlate();

            CP.AddContourPoint(point);
            CP.AddContourPoint(point2);
            CP.AddContourPoint(point3);
            CP.Finish = "FOO";
            CP.Profile.ProfileString = "PL25";
            CP.Material.MaterialString = "IS2062_GR25Thk_25.03kg";

            bool Result = false;
            Result = CP.Insert();
            model.CommitChanges();
        }

        public static  void CreateToeAngle(Point startPoint, Point endPoint, string profileString, string materialString)
        {
            Beam beam = new Beam(startPoint, endPoint);
            

            beam.Name = "TOE ANGLE";
            beam.Profile.ProfileString = profileString; // Set the beam profile 
            beam.Material.MaterialString = materialString; // Set the beam material 
            beam.Insert(); // Insert the beam into the model.
            model.CommitChanges();

        }

        public static void CreatePolyBeam(Point startPoint, Point endPoint, string profileString, string materialString)
        {
            double radius = endPoint.Y;

            // Calculate the center point of the curve
            ContourPoint centerPoint1 = new ContourPoint(new Point(8297919.0, 4474114.1, 118150.0), null);
            ContourPoint contourPointStart = new ContourPoint(startPoint, null);
            ContourPoint contourPointEnd = new ContourPoint(endPoint, null);


            PolyBeam beam = new PolyBeam();// Define the start and end points of the beam.

            beam.Name = "HANDRAIL";
            beam.Profile.ProfileString = profileString; // Set the beam profile to HEA300.
            beam.Material.MaterialString = materialString; // Set the beam material to S235.
            beam.Position.Plane = Position.PlaneEnum.LEFT;


            beam.Contour.ContourPoints.Add(contourPointStart);
            beam.Contour.ContourPoints.Add(centerPoint1);
            beam.Contour.ContourPoints.Add(contourPointEnd);
            //beam.Contour.ContourPoints.Add(centerPoint);
            beam.Insert(); // Insert the beam into the model.
            model.CommitChanges();
        }

        public static void  createLadder()
        {
            Component component = new Component();
            component.Name = "Ladder";
            component.Number = 1000060;
            //component.SetAttribute();
            component.Insert();
            model.CommitChanges();

        }
    }
}
