using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ResizeControls
{
    /// <summary>
    /// C# class for the automatic resizing and scaling of UI elements in Windows Forms.
    /// </summary>
    public static class ResizeHelper
    {
        private static double originalFormWidth;
        private static double originalFormHeight;

        private static List<Control> formControls;

        private static List<double> originalControlsWidths;
        private static List<double> originalControlsHeights;

        private static List<Point> originalControlsLocations;

        private static List<float> originalControlsFontSizes;

        /// <summary>
        /// Collects the original design parameters of all the controls on the form. Call inside the form load events.
        /// </summary>
        public static void InitializeResize(Form form)
        {
            originalFormWidth = form.Width;
            originalFormHeight = form.Height;

            formControls = GetAllControls(form);

            originalControlsWidths = formControls.Select(a => (double)a.Width).ToList();
            originalControlsHeights = formControls.Select(b => (double)b.Height).ToList();

            originalControlsLocations = formControls.Select(c => c.Location).ToList();

            originalControlsFontSizes = formControls.Select(d => d.Font.Size).ToList();
        }

        /// <summary>
        /// Applies the scaling of all the controls on the form based on the original and new form size.
        /// </summary>
        public static void ApplyResize(Form form)
        {
            if (formControls == null || !formControls.Any())
            {
                return;
            }

            double widthScale = form.Width / originalFormWidth;
            double heightScale = form.Height / originalFormHeight;

            float fontScale = (float)((widthScale + heightScale) / 2.0);

            int index = 0;

            foreach (Control control in formControls)
            {
                // Resize controls.
                control.Width = (int)(widthScale * originalControlsWidths[index]);
                control.Height = (int)(heightScale * originalControlsHeights[index]);

                // Reposition controls.
                control.Location = new Point((int)(widthScale * (double)Convert.ToInt32(originalControlsLocations[index].X)),
                                            (int)(heightScale * (double)Convert.ToInt32(originalControlsLocations[index].Y)));

                // Scales controls text.
                control.Font = new Font(control.Font.FontFamily, fontScale * originalControlsFontSizes[index]);

                index++;
            }
        }

        /// <summary>
        /// Recursively collects all the controls on the form.
        /// </summary>
        public static List<Control> GetAllControls(Control parentControl)
        {
            List<Control> controls = new List<Control>();

            foreach (Control childControl in parentControl.Controls)
            {
                controls.Add(childControl);

                if (childControl.HasChildren)
                {
                    controls.AddRange(GetAllControls(childControl));
                }
            }

            return controls;
        }
    }
}
