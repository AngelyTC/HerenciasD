using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HerenciasD
{
    public partial class _Default : Page
    {
        List<ClasePadre> padres = new List<ClasePadre>();
        List<Nieta> nietas = new List<Nieta>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ClasePadre padre = new ClasePadre();
            padre.padre1 = 1;
            padre.Calcular();

            Nieta nieta = new Nieta();
            nieta.padre1= 5;
        }
    }
}