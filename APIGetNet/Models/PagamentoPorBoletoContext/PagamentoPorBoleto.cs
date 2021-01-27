using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIGetNet.Models
{
    public class PagamentoPorBoleto
    {
        [Required]
        public string seller_id { get; set; }
        [Required]
        public string amount { get; set; }
        public string currency { get; set; }

        [Required]
        public Order order { get; set; }
        [Required]
        public Boleto boleto { get; set; }
        [Required]
        public Customer customer { get; set; }

        public void MockContextPagamentoPorBoleto()
        {
            var billing_addressMock = new Billing_address();
            billing_addressMock.street = "Av. Brasil";
            billing_addressMock.number = "1000";
            billing_addressMock.district = "São Geraldo";
            billing_addressMock.city = "Porto Alegre";
            billing_addressMock.state = "RS";
            billing_addressMock.postal_code = "90230060";
        
            var orderMock = new Order();
            orderMock.order_id = "12345";
            var boletoMock = new Boleto();
            var customerMock = new Customer();
            customerMock.name = "JOAO DA SILVA";
            customerMock.document_type = "CPF";
            customerMock.document_number = "82916868070";
            customerMock.billing_address = billing_addressMock;
        
            this.seller_id = "d0e5e129-8dc9-4633-b516-1100e2db3749";
            this.amount = "1000";
            this.order = orderMock;
            this.boleto = boletoMock;
            this.customer = customerMock;
        }

        public void MockContextPagamentoPorBoletoCompleto()
        {
            var billing_addressMock = new Billing_address();
            billing_addressMock.street = "Av. Brasil";
            billing_addressMock.number = "1000";
            billing_addressMock.complement = "Sala 1";
            billing_addressMock.district = "São Geraldo";
            billing_addressMock.city = "Porto Alegre";
            billing_addressMock.state = "RS";
            billing_addressMock.postal_code = "90230060";

            var orderMock = new Order();
            orderMock.order_id = "12345";
            orderMock.sales_tax = 0;
            orderMock.product_type = "service";
            var boletoMock = new Boleto();
            boletoMock.our_number = "000001946598";
            boletoMock.document_number = "170500000019763";
            boletoMock.expiration_date = "01/01/2077";
            boletoMock.instructions = "Não receber após o vencimento";
            boletoMock.provider = "santander";
            var customerMock = new Customer();
            customerMock.name = "JOAO DA SILVA";
            customerMock.document_type = "CPF";
            customerMock.document_number = "82916868070";
            customerMock.first_name = "João";
            customerMock.billing_address = billing_addressMock;

            this.seller_id = "d0e5e129-8dc9-4633-b516-1100e2db3749";
            this.amount = "1000";
            this.currency = "BRL";
            this.order = orderMock;
            this.boleto = boletoMock;
            this.customer = customerMock;
        }

        public void StringForNull()
        {
            seller_id = (seller_id != "string") ? seller_id : null;
            amount = (amount != "string") ? amount : null;
            currency = (currency != "string") ? currency : null;

            order.StringForNull();
            boleto.StringForNull();
            customer.StringForNull();
            customer.billing_address.StringForNull();
        }

    }
}
//{
//  "seller_id": "6eb2412c-165a-41cd-b1d9-76c575d70a28",
//  "amount": 100,
//  "currency": "BRL",
//  "order": {
//    "order_id": "6d2e4380-d8a3-4ccb-9138-c289182818a3",
//    "sales_tax": 0,
//    "product_type": "service"
//  },
//  "boleto": {
//    "our_number": "000001946598",
//    "document_number": "170500000019763",
//    "expiration_date": "16/11/2017",
//    "instructions": "Não receber após o vencimento",
//    "provider": "santander"
//  },
//  "customer": {
//    "first_name": "João",
//    "name": "João da Silva",
//    "document_type": "CPF",
//    "document_number": "12345678912",
//    "billing_address": {
//      "street": "Av. Brasil",
//      "number": "1000",
//      "complement": "Sala 1",
//      "district": "São Geraldo",
//      "city": "Porto Alegre",
//      "state": "RS",
//      "postal_code": "90230060"
//    }
//  }
//}