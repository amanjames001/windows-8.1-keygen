namespace windows_8._1_keygen
{
    public partial class Form1 : Form
    {
        // Array to store the keys
        private string[] keys = {
            "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9",
            "XKY4K-2NRWR-8F6P2-448RF-CRYQH",
            "N6KXJ-P6YWY-4C92Q-J7BVB-R6XGM",
            "MMRNH-BMB4F-87JR9-D72RY-MY2KV",
            "KQWNF-XPMXP-HDK3M-GBV69-Y7RDH",
            "3FCND-JTWFM-24VQ8-QXTMB-TXT67",
            "N4WY8-DVW92-GM8WF-CG872-HH3G7",
            "ND8P2-BD2PB-DD8HM-2926R-CRYQH",
            "T3NJK-3P683-2T7BJ-2X27F-8B2KV",
            "HB39N-V9K6F-P436V-KWBTC-Q3R9V",
            "QGR4N-78PMD-KCRQ7-83BXT-YG667",
            "6PN82-R4BBH-XX8K2-DCK84-VMFDH",
            "BTNJ7-FFMBR-FF9BH-7QMJ9-H49T7",
            "G9XNM-YYY38-8R9HM-YFPTX-T8XT7",
            "CR8NG-63KCR-X2MPD-G7M7P-GQ4DH",
            "NGMMV-FVDXB-QP6XF-9FTRT-P7F9V",
            "7TWWK-WNB2W-VRVPV-XG6RV-MBFDH",
            "HN42W-QF3D6-2KM6W-C79XK-JW8XV",
            "RFQ3N-4Y4XR-JY9PV-883PR-BY2KV",
            "VC972-N7YXW-G9WQY-VBDP4-GXT67",
            "GX9N8-4H2FH-D987T-BQ9GK-XKT67",
            "KKPMN-469HY-H6V43-T8VX2-8W8XV",
            "T3NJK-3P683-2T7BJ-2X27F-8B2KV",
            "84NRV-6CJR6-DBDXH-FYTBF-4X49V",
            "BDDNV-BQ27P-9P9JJ-BQJ96-KTJXV",
            "967N4-R7KXM-CJKJB-BHGCW-CPKT7",
            "KQWNF-XPMXP-HDK3M-GBV69-Y7RDH"

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(keys.Length);

            // Set the randomly selected key to the text box
            textBox1.Text = keys[index];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
