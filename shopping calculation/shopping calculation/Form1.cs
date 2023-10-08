using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping_calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // bookQuantity == kitap Adet 
        private void button1_Click(object sender, EventArgs e)
        {
            int bookQuantity;
            double total;
            bookQuantity = Convert.ToInt16(textBox1.Text);
            if( bookQuantity >= 0 && bookQuantity <= 20)
            {
                total = (bookQuantity * 40 - bookQuantity * 40 * 0.20);
                label3.Text = total + " TL";

            }
            if(bookQuantity >= 21 && bookQuantity <= 40)
            {
                total = (bookQuantity * 40 - bookQuantity * 40 * 0.40);
                label3.Text = total + " TL";
            }
            if (bookQuantity >= 41)
            {
                total = (bookQuantity * 40 - bookQuantity * 40 * 0.50);
                label3.Text = total + " TL";
            }
        }
    }
}

// 0-20 ==> % 20
// 21-40 ==> % 40
// 41++ ==> % 50
//kitap=40 TL 