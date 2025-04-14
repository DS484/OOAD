
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Payment {

    public Payment() {
    }

    private int id;

    private Double amount;

    private DateTime paymentDate;

    private string paymentMethod;

    private string status;

    private VietQRProcess vietQRProcess;

    

    public string getPaymentMethod() {
        return paymentMethod;
    }


    public void setStatus(string status) {
        // TODO implement here
    }

    public void savePayment() {
        // TODO implement here
    }

    public string processPayment(Reservation reservation) {
        string paymentMethod = this.getPaymentMethod();
        if (paymentMethod == "Cash")
        {
            setStatus("Unpaid");
        } 
        else if (paymentMethod == "VietQR")
        {
            vietQRProcess = new VietQRProcess();
            bool result = vietQRProcess.processPayment(reservation);

            if (result)
            {
                return "Payment fail";
            } else
            {
                setStatus("Paid");
            }
        }

        // lưu thông tin payment
        savePayment();
        return "Payment success";
    }

}