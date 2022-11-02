private void button_1(object sender, EventArgs e) {  
    if (textBox.Text == "0" || cal) {  
        textBox.Clear();  
    }  
    cal = false;  
    Button button = (Button) sender;  
    if (textBox.Text == ".") {  
        if (!textBox.Text.Contains(".")) {  
            textBox.Text += button.Text;  
        }  
    } else textBox.Text += button.Text;  
  // this is work by this numbers of button    
}   

private void button_39(object sender, EventArgs e) {  
    switch (bccc) {  
        case "+"  
        textBox.Text = (firstdigit + double.Parse(textBox.Text)).ToString();  
        break;  
        case "-"  
        textBox.Text = (firstdigit - double.Parse(textBox.Text)).ToString();  
        break;  
        case "*"  
        textBox.Text = (firstdigit * double.Parse(textBox.Text)).ToString();  
        break;  
        case "/"  
        textBox.Text = (firstdigit / double.Parse(textBox.Text)).ToString();  
        break;  
    }  
}  

private void button_22(object sender, EventArgs a) {  
    int index = textBox.Text.Length;  
    index--;  
    textBox.Text = textBox.Text.Remove(index);  
    if (textBox.Text == "") {  
        textBox.Text = "0";  
    }  
}   

 private void button_21(object sender, EventArgs a)  
 {  
    textBox.Text = "0";  
 }  

  private void button_23(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = result * -1;  
    textBox.Text = result.ToString();  
 } 

  private void button_11(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Squareroot(result);  
   
    textBox.Text = result.ToString();  
 } 

  private void button_18(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = result / 100;  
    textBox.Text = result.ToString();  
 }  

  private void button_19(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Ceiling(result);  
    textBox.Text = result.ToString();  
 } 

  private void button_20(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Floor(result);  
    textBox.Text = result.ToString();  
 }  

  private void button_12(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Power(result,2);  
    textBox.Text = result.ToString();  
 } 

  private void button_14(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Power(result,3);  
    textBox.Text = result.ToString();  
 }  

  private void button_14(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = 1/result;  
    textBox.Text = result.ToString();  
 }  

  private void button_15(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = (firstdigit % double.Parse(textBox.Text));  
    textBox.Text = result.ToString();  
 }  

  private void button_6(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Log10(result);  
    textBox.Text = result.ToString();  
 } 

  private void button_7(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Sin(result);  
    textBox.Text = result.ToString();  
 }  

  private void button_8(object sender, EventArgs a)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Cos(result);  
    textBox.Text = result.ToString();  
 } 

  private void button_9(object sender, EventArgs e)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Tan(result);  
    textBox.Text = result.ToString();  
 } 

  private void button_10(object sender, EventArgs e)  
 {  
   
    result = Math.PI;  
    textBox.Text = result.ToString();  
 }  

  private void button_11(object sender, EventArgs e)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Exp(result);  
    textBox.Text = result.ToString();  
}  

 private void button_12(object sender, EventArgs e)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Tanh(result);  
    textBox.Text = result.ToString();  
 }  

  private void button_13(object sender, EventArgs e)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Cosh(result);  
    textBox.Text = result.ToString();  
 }  

  private void button_2(object sender, EventArgs e)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Sinh(result);  
    textBox.Text = result.ToString();  
 }  

  private void button_1(object sender, EventArgs e)  
 {  
    Application.Exit();  
 }  

  private void button_17(object sender, EventArgs e)  
 {  
    result = double.Parse(textBox.Text);  
    result = Math.Log(result);  
    textBox.Text = result.ToString();}  