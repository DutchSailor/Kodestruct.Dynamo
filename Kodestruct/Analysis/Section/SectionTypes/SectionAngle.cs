#region Copyright
   /*Copyright (C) 2015 Konstantin Udilovich

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   */
#endregion
 
#region

using Autodesk.DesignScript.Runtime;
using Dynamo.Models;
using System.Collections.Generic;
using Dynamo.Nodes;
using Kodestruct.Common;
using Kodestruct.Common.Section.Interfaces;
using ds = Kodestruct.Common.Section.SectionTypes;
using System;

#endregion

namespace Analysis.Section.SectionTypes
{


    public partial class SectionAngle: CustomProfile
    {

        [IsVisibleInDynamoLibrary(false)]
        internal SectionAngle(double b, double h, double t, string AngleRotation, string AngleOrientation)
        {
            AngleRotation angleRotation;
            bool IsValidString1 = Enum.TryParse(AngleRotation, true, out angleRotation);
            if (IsValidString1 != true)
            {
                throw new Exception("Angle rotation not recognized. Check string.");
            }

            AngleOrientation angleOrientation;
            bool IsValidString2 = Enum.TryParse(AngleOrientation, true, out angleOrientation);
            if (IsValidString2 != true)
            {
                throw new Exception("Angle orientation not recognized. Check string.");
            }

            ISection r = new ds.SectionAngle("", b, h, t, angleRotation, angleOrientation);
            Section = r;
        }

        public static SectionAngle ByWidthHeightThickness(double b, double h, double t, string AngleRotation, string AngleOrientation)
        {
            return new SectionAngle(b, h, t, AngleRotation,  AngleOrientation);
        }

    }
}
