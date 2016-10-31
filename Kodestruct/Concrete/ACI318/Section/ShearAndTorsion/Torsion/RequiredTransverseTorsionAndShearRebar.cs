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
using Concrete.ACI318.Section.SectionTypes;
using Concrete.ACI318.General.Reinforcement;
using Kodestruct.Concrete.ACI;
using Kodestruct.Concrete.ACI318_14;

#endregion

namespace Concrete.ACI318.Section.ShearAndTorsion.Torsion
{

/// <summary>
///     Required transverse torsion rebar
///     Category:   Concrete.ACI318.Section.ShearAndTorsion.Torsion
/// </summary>
/// 

    public partial class Torsion 
    {
        /// <summary>
        ///     Required transverse torsion rebar
        /// </summary>
        /// <param name="ConcreteSection">  Reinforced concrete section </param>
        /// <param name="T_u"> Factored torsional moment at section  </param>
        /// <param name="RebarMaterial">  Reinforcement material object. Create the object using input parameters first </param>
        /// <param name="c_transv_ctr">Concrete cover to closed stirrups</param>
        /// <param name="s">   Center-to-center spacing of items, such as longitudinal reinforcement, transverse reinforcement,  tendons, or anchors  </param>
        /// <param name="Code">Applicable version of code/standard</param>
        /// <returns name="A_v">  Area of shear reinforcement within spacing s  </returns>

        [MultiReturn(new[] { "A_v" })]
        public static Dictionary<string, object> RequiredTransverseTorsionAndShearRebar(ConcreteFlexureAndAxiaSection ConcreteSection, double T_u, RebarMaterial RebarMaterial,
            double c_transv_ctr, double s, string Code = "ACI318-14")
        {
            //Default values
            double A_v = 0;


            //Calculation logic:

            //TorsionShapeFactory tss = new TorsionShapeFactory();
            //IConcreteTorsionalShape shape = tss.GetShape(ConcreteSection.FlexuralSection, ConcreteSection.ConcreteMaterial.Concrete, c_transv_ctr);
            //ConcreteSectionTorsion sec = new ConcreteSectionTorsion(shape);
            //A_v = sec.GetRequiredTorsionTransverseReinforcementArea(T_u, RebarMaterial.Material.YieldStress);

            return new Dictionary<string, object>
            {
                { "A_v", A_v }
 
            };
        }


    }
}


