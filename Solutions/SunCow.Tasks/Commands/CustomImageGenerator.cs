using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SunCow.Domain;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Web;
using SunCow.Domain.Contracts.Tasks;

namespace SunCow.Tasks.Commands
{
	public class CustomImageGenerator : ICustomImageGenerator 
	{
		public void Generate(CustomCard customCard, string templateServerPath, string customImageServerPath) 
		{
			//1. Generate custom inside image			

			using (var rectangleFont = new Font("Arial", 14, FontStyle.Bold))
			{
				using (var bitmap = new Bitmap(templateServerPath))
				{
					using (var g = Graphics.FromImage(bitmap))
					{
						g.SmoothingMode = SmoothingMode.AntiAlias;
						var backgroundColor = Color.Bisque;
						g.Clear(backgroundColor);
						g.DrawString(customCard.InsideMessage, rectangleFont, SystemBrushes.WindowText, new PointF(10, 40));
						bitmap.Save(customImageServerPath, ImageFormat.Png);
					}
				}
			}
		}

	}
}
