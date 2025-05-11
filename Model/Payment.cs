
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel_Management.DAO;

public class Payment {

    public Payment() {
    }

    private int id;

    private Double amount;

    private DateTime paymentDate;

    private string paymentMethod;

    private string status;

    private VietQRProcess vietQRProcess;

    public DateTime getPaymentDate() {
        return paymentDate;
    }

    public string getPaymentMethod() {
        return paymentMethod;
    }

    public string getStatus() {
        return status;
    }
    public double getAmount()
    {
        return amount;
    }

    public void setPaymentDate(DateTime paymentDate) {
        this.paymentDate = paymentDate;
    }

    public void setStatus(string status) {
        this.status = status;
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

    public void savePayment()
    {
        string sql = "INSERT INTO Payment (Amount, PaymentDate, PaymentMethod, Status) " +
                     "VALUES (@Amount, @PaymentDate, @PaymentMethod, @Status)";

        object[] parameters = new object[]
        {
        amount,
        paymentDate,
        paymentMethod,
        status
        };

        new DBConnection().ExecuteQuery(sql, parameters);
    }
}