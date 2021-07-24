using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoWindowApp
{
    public partial class Form1 : Form
    {
        public class Book
        {
            string title;
            string author;
            int page;
            string ISBN;
            string publisher;

            public Book(string title, string author, int page, string ISBN, string publisher)
            {
                this.title = title;
                this.author = author;
                this.page = page;
                this.ISBN = ISBN;
                this.publisher = publisher;
            }

            public string Title
            {
                get { return title; }
                set { title = value; }
            }
            public override string ToString()
            {
                return "title: " + title + ", author: " + author + ", page:" + page + ", ISBN: " + ISBN + ", publisher: " + publisher;
            }
        }
        interface Sale
        {
            void DiscountPrice(int discount);
            void StockOut();
            void StorageInWareHouse();
        }
        public class EBook : Book, Sale
        {
            int price;
            Boolean outOfStock = false;

            public EBook(string title, string author, int page, string ISBN, string publisher, int price) : base(title, author, page, ISBN, publisher)
            {
                this.price = price;
            }
            public int Price
            {
                get { return price; }
                set { price = value; }
            }
            public Boolean OutOfStock
            {
                get { return outOfStock; }
                set { outOfStock = value; }
            }
            public override string ToString()
            {
                return base.ToString() + ", price: " + price + ", outOfStock: " + outOfStock;
            }
            public void DiscountPrice(int discount)
            {
                price -= discount;
            }
            public void StockOut()
            {
                outOfStock = true;
            }
            public void StorageInWareHouse()
            {
                outOfStock = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        EBook ebook;
        private void btnSave_Click(object sender, EventArgs e)
        {
            ebook = new EBook(txtTitle.Text, txtAuthor.Text, int.Parse(txtPages.Text), txtISBN.Text, txtPublisher.Text, int.Parse(txtPrice.Text));
            ebook.StorageInWareHouse();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            ebook.DiscountPrice(int.Parse(txtDiscount.Text));
        }

        private void btnOfS_Click(object sender, EventArgs e)
        {
            ebook.StockOut();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtResult.Text = ebook.ToString();
        }
    }

}
