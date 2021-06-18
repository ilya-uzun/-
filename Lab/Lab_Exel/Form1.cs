using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace tets2
{
    public partial class Lab3 : Form
    {
        private Excel.Application excelapp;

        private Excel.Sheets excelsheets;
        private Excel.Range excelcells;
        private Excel.Workbooks excelappworkbooks;
        private Excel.Workbook excelappworkbook;
        private Excel.Worksheet excelworksheet;

        private Word.Documents worddocuments;
        private Word.Document worddocument;
        private Word.Application wordapp;
        private Word.Paragraphs wordparagraphs;
        private Word.Paragraph wordparagraph;

        public Lab3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            excelapp = new Excel.Application();
            excelapp.Visible = true;
            //Получаем набор ссылок на объекты Workbook
            excelappworkbooks = excelapp.Workbooks;
            //Открываем книгу и получаем на нее ссылку
            excelapp.Workbooks.Open(@"G:\Project\C#\Lab3_excel\Lab3_Excel\Lab3.xls",
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            excelappworkbook = excelappworkbooks[1];
            //Получаем массив ссылок на листы выбранной книги
            excelsheets = excelappworkbook.Worksheets;
            //Получаем ссылку на лист 1
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            //Выбираем ячейку для вывода A1
            excelcells = excelworksheet.get_Range("A1", "A1");
            //Выводим строку
            excelcells.Value2 = "Лаб.№";
            //Выбираем ячейку для вывода B1
            excelcells = excelworksheet.get_Range("B1", "B1");
            excelcells.Value2 = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sStr;

            excelappworkbook = excelappworkbooks[1];
            excelsheets = excelappworkbook.Worksheets;
            ////Получаем ссылку на лист 1
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            //Выбираем ячейку для вывода A3
            excelcells = excelworksheet.get_Range("C1", Type.Missing);
            sStr = Convert.ToString(excelcells.Value2);
            Text = sStr + " ";
            label1.Text = Convert.ToString(sStr);
   
        }

        private void button_openWord_Click(object sender, EventArgs e)
        {
            wordapp = new Word.Application();
            wordapp.Visible = true;
            Object filename = @"G:\Project\C#\Lab3_excel\Lab3_Excel\Lab2.doc";
            //Настройки  Type.Missing - настройки по умолчанию
            Object confirmConversions = true;
            Object readOnly = false;
            Object addToRecentFiles = true;
            Object passwordDocument = Type.Missing;
            Object passwordTemplate = Type.Missing;
            Object revert = false;
            Object writePasswordDocument = Type.Missing;
            Object writePasswordTemplate = Type.Missing;
            Object format = Type.Missing;
            Object encoding = Type.Missing; ;
            Object oVisible = Type.Missing;
            Object openConflictDocument = Type.Missing;
            Object openAndRepair = Type.Missing;
            Object documentDirection = Type.Missing;
            Object noEncodingDialog = false;
            Object xmlTransform = Type.Missing;
            worddocument = wordapp.Documents.Open(ref filename,
 
             ref confirmConversions, ref readOnly, ref addToRecentFiles,
             ref passwordDocument, ref passwordTemplate, ref revert,
             ref writePasswordDocument, ref writePasswordTemplate,
             ref format, ref encoding, ref oVisible,
             ref openAndRepair, ref documentDirection, ref noEncodingDialog, ref xmlTransform);
        }

        private void button_writeWord_Click(object sender, EventArgs e)
        {
            //Получаем ссылки на параграфы документа
            wordparagraphs = worddocument.Paragraphs;
            //Будем работать с первым параграфом
            wordparagraph = (Word.Paragraph)wordparagraphs[1];
            //Выводим текст в первый параграф
            wordparagraph.Range.Text = "Лабораторная работа № 2";
            //Меняем характеристики текста и параграфа
            wordparagraph.Range.Font.Color = Word.WdColor.wdColorBlack;
            wordparagraph.Range.Font.Size = 20;
            wordparagraph.Range.Font.Name = "Arial";
            wordparagraph.Range.Font.Italic = 0; // курсив - 1
            wordparagraph.Range.Font.Bold = 0; // ПолужирНый шрифт - 1
                                        
            //Выравнивание
            wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

        }

        private void button_readWord4_Click(object sender, EventArgs e)
        {

            object file = @"G:\Project\C#\Lab3_excel\Lab3_Excel\Lab2.doc";
            var wordApp = new Microsoft.Office.Interop.Word.Application();

            var wordDoc = wordApp.Documents.Open(ref file);

            string text = "";
            for (int i = 0; i < wordDoc.Paragraphs.Count; i++)
            {
                text += " \r\n " + wordDoc.Paragraphs[i + 1].Range.Text;
            }
            MessageBox.Show(text);
           // wordDoc.Close();
           // wordApp.Quit();

        }

        //private void label2_Click(object sender, EventArgs e)
        //{
        //    //Задаем режим вставки
        //    wordapp.Options.Overtype = false;
        //    wordapp.Selection.Font.Italic = 0;
        //    wordapp.Selection.Font.Bold = 1;
        //    wordapp.Selection.Font.Underline = Word.WdUnderline.wdUnderlineNone;
        //    wordapp.Selection.TypeText(" Новый текст 1 ");
        //}
    }
}
// http://wladm.narod.ru/C_Sharp/comword.html
//http://wladm.narod.ru/C_Sharp/comexcel.html#z