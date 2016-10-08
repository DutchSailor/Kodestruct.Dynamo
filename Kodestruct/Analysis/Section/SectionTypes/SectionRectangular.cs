#region Copyright
   /*Copyright (C) 2015 Kodestruct Inc

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
using Kodestruct.Common.Section.Interfaces;
using ds = Kodestruct.Common.Section.SectionTypes;
using dm = Kodestruct.Common.Mathematics;

#endregion

namespace Analysis.Section.SectionTypes
{


    public partial class SectionRectangular: CustomProfile
    {

        [IsVisibleInDynamoLibrary(false)]
        internal SectionRectangular(double b, double h)
        {
            ISection  r = new ds.SectionRectangular("", b, h, new dm.Point2D(0, 0));
            Section = r;
        }

        public static SectionRectangular ByWidthHeight(double b, double h)
        {
            return new SectionRectangular(b, h);
        }

    }
}
