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
using Kodestruct.Steel.AISC.AISC360v10.Connections.WebOpenings;

#endregion

namespace Steel.AISC.Connection
{

/// <summary>
///     Maximum web opening height
///     Category:   Steel.AISC.Connection
/// </summary>
/// 



    public partial class BeamWebOpening 
    {
        /// <summary>
        ///     Maximum web opening height
        /// </summary>
        /// <param name="a_o">  Length of opening </param>
        /// <param name="d">  Full nominal depth of the section    </param>
        /// <param name="e_op">  Eccentriciy of opening with repect to neutral axis </param>
        /// <param name="t_f">  Thickness of flange   </param>
        /// <param name="t_w">  Thickness of web  </param>
        /// <param name="F_y">  Specified minimum yield stress </param>
        /// <param name="IsCompositeBeam">  Identifies whether member is composite </param>
        /// <returns name="h_op"> Height of opening </returns>

        [MultiReturn(new[] { "h_op" })]
        public static Dictionary<string, object> WebOpeningMaximumHeight(double a_o,double d,double e,double t_f,double t_w,double F_y,bool IsCompositeBeam=true)
        {
            //Default values
            double h_op = 0;


            //Calculation logic:
            h_op = WebOpeningGeneral.GetMaximumOpeningHeight(a_o, d, e, t_f, t_w, F_y, IsCompositeBeam);

            return new Dictionary<string, object>
            {
                { "h_op", h_op }
 
            };
        }



    }
}


