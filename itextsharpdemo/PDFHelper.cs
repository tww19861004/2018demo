using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itextsharpdemo
{
    public class PDFHelper
    {
        public readonly static string TemplatePath = $"{System.Environment.CurrentDirectory}\\EInvoiceTemplate.pdf";
        public readonly static string FontPath = $"{System.Environment.CurrentDirectory}\\STSONG.TTF";

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        ///使用示例：
        ///简单模版文件可以在线生成(http://www.pdfescape.com/windows/)使用Form Field创建需要填充的内容的控件
        ///var template_url = @"C:\Users\Song\Desktop\tmpplate.pdf";
        ///var save_pdf_url = @"C:\Users\Song\Desktop\new.pdf";
        ///var dic = PDFHelper.ReadForm(template_url);
        ///dic["name"] = "张三";
        ///dic["id_card"] = "111111111111";
        ///PDFHelper.FillForm(template_url, save_pdf_url, dic);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// 读取pdf模版中的标签
        /// 
        /// pdf模版文件路径
        /// 
        public static Dictionary<string, string> ReadForm(string pdfTemplate)
        {
            Dictionary<string,string> dic = new Dictionary<string, string>();
            PdfReader pdfReader = null;
            try
            {
                pdfReader = new PdfReader(pdfTemplate);
                AcroFields pdfFormFields = pdfReader.AcroFields;
                foreach (var de in pdfFormFields.Fields)
                {
                    dic.Add(de.Key, "");
                }
            }
            catch (Exception ex)
            {
                //LogHelper.Error(ex.Message);
            }
            finally
            {
                if (pdfReader != null)
                {
                    pdfReader.Close();
                }
            }
            return dic;
        }
        /// 
        /// 向pdf模版填充内容，并生成新的文件
        /// 
        /// 模版路径
        /// 生成文件保存路径
        /// 标签字典(即模版中需要填充的控件列表)
        public static void FillForm(string pdfTemplate, string newFile, Dictionary<string, string> dic)
        {
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;
            FileStream fs = null;
            MemoryStream ms = null;
            try
            {
                //fs = new FileStream(newFile, FileMode.Create);
                ms = new MemoryStream();
                pdfReader = new PdfReader(pdfTemplate);
                //pdfStamper = new PdfStamper(pdfReader, fs);
                pdfStamper = new PdfStamper(pdfReader, ms);
                AcroFields pdfFormFields = pdfStamper.AcroFields;
                //设置支持中文字体
                //BaseFont baseFont = BaseFont.CreateFont("C:\\WINDOWS\\FONTS\\STSONG.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                BaseFont baseFont = BaseFont.CreateFont(FontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                pdfFormFields.AddSubstitutionFont(baseFont);
                foreach (KeyValuePair<string,string> de in dic)
                {
                    pdfFormFields.SetField(de.Key, de.Value);
                }
                pdfStamper.FormFlattening = true;                                

            }
            catch (Exception ex)
            {
                //LogHelper.Error(ex.Message);
            }
            finally
            {
                if (pdfStamper != null)
                {
                    pdfStamper.Close();
                }
                if (pdfReader != null)
                {
                    pdfReader.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
                if (ms != null)
                {
                    ms.Close();
                    ms.Dispose();
                }
                string tempPath = $"{System.Environment.CurrentDirectory}\\{Guid.NewGuid().ToString()}.pdf";
                File.WriteAllBytes(tempPath, ms.ToArray());
                EmailHelp.SendEmail("tww24098@ly.com", "1", "2", tempPath);
            }
        }
    }
}
