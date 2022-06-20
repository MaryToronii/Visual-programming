using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_VP
{
    public partial class Form1 : Form
    {
        public int Id, nameId;
        public List<AllBooks> _AllBooks;
        public List<BookNames> _BookNames;
        public List<TakenBooks> _TakenBooks;
        public List<Reaaders> _Readers;
        public BindingSource mysourse = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.AllBooks". При необходимости она может быть перемещена или удалена.
            this.allBooksTableAdapter.Fill(this.booksDataSet.AllBooks);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cel = (DataGridViewTextBoxCell)dataGridView2.Rows[e.RowIndex].Cells[0];
            int _id = (int)cel.Value;
            BooksEntities books = new BooksEntities();
            Reaaders MyReader = books.Reaaders.Find(_id);
            PIB.Text = MyReader.Name;
            Adress.Text = MyReader.Adress;
            Birht.Text = MyReader.Birth.ToString();
            Number.Text = MyReader.Number;
            books.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cel1 = (DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0];
            DataGridViewTextBoxCell cel2 = (DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[1];
            Id = (int)cel1.Value;
            nameId = (int)cel2.Value;
            BooksEntities books = new BooksEntities();
            
            AllBooks book = books.AllBooks.Find(Id);
            BookNames MyBook = books.BookNames.Find(nameId);
            pictureBox1.Image = Image.FromFile(MyBook.Photo);
            bookName.Text = MyBook.Name;
            Athor.Text = MyBook.Athor;
            Date.Text = MyBook.Year.ToString();
            Cost.Text = MyBook.Cost.ToString();
            Publishing.Text = MyBook.Publishing;
            Genre.Text = MyBook.Genre;
            desc.Text = MyBook.ShortDescription;

            mysourse.DataSource = book.TakenBooks;
            dataGridView2.DataSource = mysourse;
            books.Dispose();
            
            
        }
    }
}
