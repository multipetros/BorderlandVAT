/*
 * BorderlandVAT - Copyright (C) 2011 Petros Kyladitis
 * A command line process killing & restaring tool
 * Developed in SharpDevelop, at C# language, targeted .NET/Mono
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace BorderlandVAT{
	public partial class MainForm : Form{
		public MainForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			comboBoxRate.SelectedIndex = 0 ;
		}
    
		
		private double HIGHER_VAT = 23 ;
		private double MIDDLE_VAT = 13 ;
		private double LOWER_VAT = 6.5 ;
		
		private double priceStringToDec(string price){
			//convert decimal separators to currency culture
			string decSeparator = System.Globalization.CultureInfo.CurrentUICulture.NumberFormat.CurrencyDecimalSeparator ;
			if(decSeparator.Equals(","))
				price = price.Replace(".", decSeparator) ;
			else
				price = price.Replace(",", decSeparator) ;
			
			try{
				return double.Parse(price, System.Globalization.NumberStyles.Currency) ;
			}catch(Exception){ //if can't convert return 0
				return 0 ;
			}
		}		
		
		private string priceDecToString(double price){
			//return the price string formated as currency
			return string.Format("{0:C}", price) ;
		}
		
		private double borderlandsPrice(double normalPrice, double normalVAT){
			//VAT in broder is 30% cutted of normal, rounded at the nearest unit
			double borderlandsVAT = Math.Round(normalVAT*0.7, 0) ;
			double netPrice = normalPrice / (1 + (normalVAT/100)) ;
			double borderlandsPrice = netPrice * (1 + (borderlandsVAT/100)) ;
			return borderlandsPrice ;
		}
		
		private void changeToBorderlandsPrice(){
			int rate = comboBoxRate.SelectedIndex ;
			if(rate == 0)
				labelPrice.Text = priceDecToString(borderlandsPrice(priceStringToDec(textBoxPrice.Text), HIGHER_VAT)) ;
			else if(rate == 1)
				labelPrice.Text = priceDecToString(borderlandsPrice(priceStringToDec(textBoxPrice.Text), MIDDLE_VAT)) ;
			else
				labelPrice.Text = priceDecToString(borderlandsPrice(priceStringToDec(textBoxPrice.Text), LOWER_VAT)) ;
		}
		
		void TextBoxPriceTextChanged(object sender, EventArgs e){
			changeToBorderlandsPrice() ;
		}
		
		void PictureBoxClearClick(object sender, EventArgs e){
			textBoxPrice.Clear() ;
		}
		
		
		void PictureBoxAboutClick(object sender, EventArgs e){
			MessageBox.Show(this, "BorderlandVAT - Έκδοση: 1.5.0\n\nΕφαρμογή υπολογισμού της τελικής τιμής προϊόντων από καταλόγους με κανονικό ΦΠΑ σε τελικές τιμές με μειωμένο ΦΠΑ όπως ισχύει για τα νησιά των νομών Λέσβου, Χίου, Σάμου, Δωδεκανήσου, Κυκλάδων και τα νησιά του Αιγαίου Θάσο, Σαμοθράκη, Βόρειες Σποράδες και Σκύρο.\n\nΣτην τρέχουσα έκδοση\n- υψηλός συντελεστής κανονικού ΦΠΑ: 23%\n- μεσαίος συντελεστής κανονικού ΦΠΑ: 13%\n- χαμηλός συντελεστής κανονικού ΦΠΑ: 6,5%\n\nΤο πρόγραμμα είναι ελεύθερο λογισμικό και διανέμεται με τους όρους της άδειας χρήσης GNU General Public License. (Το κείμενο της άδειας, αν δεν σας παραδώθηκε μαζί με την εφαρμογή, μπορείτε να το βρείτε στη διεύθυνση http://www.gnu.org/licenses/)\n\n(C) 2011 - Πέτρος Κυλαδίτης", "Πληροφορίες εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
		}
		
		//make form top most
		void PictureBoxSettingsClick(object sender, EventArgs e){
			if(!this.TopMost){
				this.TopMost = true ;
				pictureBoxSettings.BackColor = Color.Yellow ;
			}else{
				this.TopMost = false ;
				pictureBoxSettings.BackColor = Color.FromKnownColor(KnownColor.Control) ;
			}			
		}
		
		void PictureBoxAboutMouseHover(object sender, EventArgs e){
			ToolTip tip = new ToolTip() ;
			tip.SetToolTip(this.pictureBoxAbout, "Πληροφορίες για το πρόγραμμα") ;
		}
		
		void PictureBoxSettingsMouseHover(object sender, EventArgs e){
			ToolTip tip = new ToolTip() ;
			tip.SetToolTip(this.pictureBoxSettings, "Πάντα σε πρώτο πλάνο (on/off)") ;
		}
		
		void PictureBoxClearMouseHover(object sender, EventArgs e){
			ToolTip tip = new ToolTip() ;
			tip.SetToolTip(this.pictureBoxClear, "Σβήσιμο κειμένου") ;
		}
		
		void ComboBoxMouseHover(object sender, EventArgs e){
			ToolTip tip = new ToolTip() ;
			tip.SetToolTip(this.comboBoxRate, "Συντελεστής ΦΠΑ\nΥψηλός: Ό,τι δεν εντάσεται στα παρακάτω\nΜεσαίος: Τρόφιμα, Λιπάσματα κλπ.\nΧαμηλός: Εισιτήρια θεάτρων, Βιβλία, Ξενοδοχεία κλπ.\nΓια την πλήρη λίστα δείτε το άρθρο 21 παρ. ΙΙΙ του Κώδικα ΦΠΑ (Ν. 2859/2000)") ;
		}
		
		void ComboBoxRateSelectedValueChanged(object sender, EventArgs e){
			changeToBorderlandsPrice() ;
		}
	}
}
