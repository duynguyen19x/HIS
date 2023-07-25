using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class ProvinceBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SProvince>().HasData(
               new SProvince() { Id = new Guid("btziYNvv-EsDZ-SMWy-IQ2F-gDXLX9Yk0FcB"), Code = "01", Name = "Thành phố Hà Nội", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("Op4Axab0-VymR-NVrx-UR2S-iHS0TPqG9mPi"), Code = "02", Name = "Tỉnh Hà Giang", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("0b2u1TGV-Il5V-9us0-DTEG-KFf8zAsSGBlA"), Code = "04", Name = "Tỉnh Cao Bằng", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("6iGd2MFk-C2Kj-EkL3-GBo1-XkDj3OWvExi5"), Code = "06", Name = "Tỉnh Bắc Kạn", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("NfJT18kr-IfIt-swd8-xYSC-7livvf5Ujal2"), Code = "08", Name = "Tỉnh Tuyên Quang", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("Jv18zpMO-tWKG-Iyk7-Lnby-dhRYBOKSTMwM"), Code = "10", Name = "Tỉnh Lào Cai", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("7KCk92i3-qmFo-WCfn-5ONu-mw10oMpVT44Z"), Code = "11", Name = "Tỉnh Điện Biên", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("czdJdZiD-1IV5-EHAE-X3dP-liTzx9aQy1gb"), Code = "12", Name = "Tỉnh Lai Châu", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("Ob8ADcwN-Wrzk-v31K-bEMI-kvyIyZbtu6Hl"), Code = "14", Name = "Tỉnh Sơn La", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("X4yWdqKZ-Lf69-ij78-PDB2-mNHTBnyuw4UL"), Code = "15", Name = "Tỉnh Yên Bái", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("q3XCxQYD-Zuaj-Bhmt-uWUB-TejLnYvQSuyu"), Code = "17", Name = "Tỉnh Hoà Bình", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("VIJaeQhh-QTzp-xFko-8App-CSL9kKfcoV4k"), Code = "19", Name = "Tỉnh Thái Nguyên", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("p3axmvQK-914L-x8We-I3Eq-JOfAKZvl067h"), Code = "20", Name = "Tỉnh Lạng Sơn", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("QEKFI51t-jXSo-qak8-ebHw-qOKevdgVjc4f"), Code = "22", Name = "Tỉnh Quảng Ninh", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("KyxRxsoe-skF8-qCco-Smws-eXmbwXDPtfFm"), Code = "24", Name = "Tỉnh Bắc Giang", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("XYCpx0fu-lave-fpLB-s4xy-HefHtxbxq0yb"), Code = "25", Name = "Tỉnh Phú Thọ", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("JsmcAhJg-CWXB-3fyL-wFpA-CvPaZVTLlLY4"), Code = "26", Name = "Tỉnh Vĩnh Phúc", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("CCeNWdWi-bT21-Hnz4-378H-4vDxsyWwxFVt"), Code = "27", Name = "Tỉnh Bắc Ninh", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("ZvzTv3f4-SJNY-2u4v-h326-JuzyixuIZHeL"), Code = "30", Name = "Tỉnh Hải Dương", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("1lJz7REx-kW1G-Rq16-7GEE-lEBmLYtOjq1O"), Code = "31", Name = "Thành phố Hải Phòng", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("IQTEGcLg-0hFP-IR97-4dzT-Y4KmbU0SX26U"), Code = "33", Name = "Tỉnh Hưng Yên", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("56VDH3Qe-Wg08-DLqI-GRAF-qhcaSr8x7xfZ"), Code = "34", Name = "Tỉnh Thái Bình", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("yFlyS1R9-Q4FQ-VcuV-qfet-5dYD8rewAXcT"), Code = "35", Name = "Tỉnh Hà Nam", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("v0kmpuQ1-bnpn-XHmr-9OCs-U7fkJgbDC3pW"), Code = "36", Name = "Tỉnh Nam Định", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("uNGPKjyv-Gof1-oMwK-ma6d-alOOIQFxcfAX"), Code = "37", Name = "Tỉnh Ninh Bình", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("KcsVXN7g-1zET-KkT7-FWuz-mDc1liAxpoeK"), Code = "38", Name = "Tỉnh Thanh Hóa", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("pyw62cNF-k0Gt-ZV96-1XoO-3te8dYGT3aRX"), Code = "40", Name = "Tỉnh Nghệ An", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("EsQPXMGL-AYzZ-rXMV-eDfy-I4mzOmuUkIlC"), Code = "42", Name = "Tỉnh Hà Tĩnh", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("YNF0KP4y-HwrL-fQI8-FTGB-7SDoBMBGNm00"), Code = "44", Name = "Tỉnh Quảng Bình", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("XlZgMjWA-I59Y-LZvX-gsaT-Fbw61D6HZXbm"), Code = "45", Name = "Tỉnh Quảng Trị", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("AhGPqAP4-dWR8-ZMWd-r0jQ-lgQdRJzX6MDO"), Code = "46", Name = "Tỉnh Thừa Thiên Huế", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("9qU26nJu-UwyD-YZn4-P4lB-J2MERQWIxpun"), Code = "48", Name = "Thành phố Đà Nẵng", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("sWaVkBb3-yJsI-LGkO-YQWz-hRsWdiJQ9b79"), Code = "49", Name = "Tỉnh Quảng Nam", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("bw8djs68-UHij-uk1U-ETjN-Fwjoc7B90dVV"), Code = "51", Name = "Tỉnh Quảng Ngãi", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("KZblpDcd-ya6b-0fOn-cBpv-W14emSWiBcD5"), Code = "52", Name = "Tỉnh Bình Định", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("SNG7UVQu-mIQ2-QBNu-wAsv-5HGVkCtPtzDP"), Code = "54", Name = "Tỉnh Phú Yên", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("c8Xf2hx2-zd9F-MERN-0AL1-8NvyqG5WG3ge"), Code = "56", Name = "Tỉnh Khánh Hòa", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("UFGeXCrM-9tTz-ISPU-TigV-nA0WQweI8uBA"), Code = "58", Name = "Tỉnh Ninh Thuận", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("8Baecf8s-fIqj-zcYz-GBaP-WH0agizYnpoH"), Code = "60", Name = "Tỉnh Bình Thuận", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("ZR1biNyP-ZXsA-ojop-8ifW-yxzWq0UdqqE8"), Code = "62", Name = "Tỉnh Kon Tum", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("JmhYbtl5-d3Ev-Otn8-yXri-GeP9IjnUuSwR"), Code = "64", Name = "Tỉnh Gia Lai", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("H7Duxu42-6IBi-Ftti-fSaJ-sReZdDcm2fMl"), Code = "66", Name = "Tỉnh Đắk Lắk", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("75m4VvWD-W3jc-uQH5-un96-x7mnwsZWrGmx"), Code = "67", Name = "Tỉnh Đắk Nông", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("jfs1u4ET-3FpO-jEIA-gyOu-t0OlhJ5Y2Hbh"), Code = "68", Name = "Tỉnh Lâm Đồng", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("2QDOGXS5-GN2Q-qo3u-ZLNa-qoL791yKKrAn"), Code = "70", Name = "Tỉnh Bình Phước", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("u5Dcrwy5-Cvti-I4YB-IEn1-gl5jhcj1nj7t"), Code = "72", Name = "Tỉnh Tây Ninh", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("DFNO7dBU-Sxhs-GUaV-1geQ-TiPaQB5coJFm"), Code = "74", Name = "Tỉnh Bình Dương", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("9Dt5WBjz-1o60-6fJW-4EPc-2VRTVCXMf6ra"), Code = "75", Name = "Tỉnh Đồng Nai", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("IhUa0Q73-3mKk-bpvV-wJXg-OsvlMKapBqZV"), Code = "77", Name = "Tỉnh Bà Rịa - Vũng Tàu", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("77syDkdY-RHDY-lSXS-34fO-9lEpX6OQRvKk"), Code = "79", Name = "Thành phố Hồ Chí Minh", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("SAxMW3Aw-OeKh-1zmY-loJY-hmsTuFEHrcge"), Code = "80", Name = "Tỉnh Long An", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("D43fjaeR-JewT-rtxY-WtuB-o49zQIG0QWRg"), Code = "82", Name = "Tỉnh Tiền Giang", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("MurQdtlA-1orM-3EK2-Lt94-fOD64gD7OfIt"), Code = "83", Name = "Tỉnh Bến Tre", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("FgceGbpR-Iq73-pZWa-zgda-jzMDjaMviAxM"), Code = "84", Name = "Tỉnh Trà Vinh", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("ko4ZXS1K-6y0H-S4sd-Vtm0-ymvSjQxvVARv"), Code = "86", Name = "Tỉnh Vĩnh Long", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("oepDinq6-3GNR-vkvy-mOof-Idt0p1pVe1d3"), Code = "87", Name = "Tỉnh Đồng Tháp", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("JwOcoJjq-Zfiw-l0vS-Xjx3-5nit1pxcorCJ"), Code = "89", Name = "Tỉnh An Giang", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("ROIcrhII-j6X7-OBXk-ISsd-BCXbJCCPefNv"), Code = "91", Name = "Tỉnh Kiên Giang", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("fWBO0eRO-sa5X-Vmmo-GKyf-NycPf55o6OhZ"), Code = "92", Name = "Thành phố Cần Thơ", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("0penDo4P-Aqe1-mleN-7tEt-9PEuiMZM8w0N"), Code = "93", Name = "Tỉnh Hậu Giang", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("oxFb8GLy-63RP-hfMH-IOmG-X19jVBMSvX2u"), Code = "94", Name = "Tỉnh Sóc Trăng", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("0dmZhKod-pKPx-zOuF-ct7t-Mm8pUcpc5UIj"), Code = "95", Name = "Tỉnh Bạc Liêu", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") },
               new SProvince() { Id = new Guid("IUXh7kBB-o4SS-Vaoz-NEuu-z5eqn62oosZD"), Code = "96", Name = "Tỉnh Cà Mau", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") });
        }
    }
}
