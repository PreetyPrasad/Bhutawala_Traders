using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inventroy.Migrations
{
    /// <inheritdoc />
    public partial class initdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceMasters",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossAmount = table.Column<double>(type: "float", nullable: false),
                    GSTAmount = table.Column<double>(type: "float", nullable: false),
                    GST_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoticePeriod = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceMasters", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GSTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanckBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IFSC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qty = table.Column<double>(type: "float", nullable: false),
                    Net_Qty = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                    table.ForeignKey(
                        name: "FK_Materials_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseMasters",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    GrossTotal = table.Column<double>(type: "float", nullable: false),
                    GST_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticePeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseMasters", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_PurchaseMasters_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDates",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Qty = table.Column<double>(type: "float", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GST = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDates", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_InvoiceDates_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inwordstocks",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    PurchaseId = table.Column<int>(type: "int", nullable: false),
                    PurchaseMasterPurchaseId = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    RecivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inwordstocks", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Inwordstocks_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inwordstocks_PurchaseMasters_PurchaseMasterPurchaseId",
                        column: x => x.PurchaseMasterPurchaseId,
                        principalTable: "PurchaseMasters",
                        principalColumn: "PurchaseId");
                });

            migrationBuilder.CreateTable(
                name: "CreditNotes",
                columns: table => new
                {
                    CreditId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteNo = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDateInvoiceId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditNotes", x => x.CreditId);
                    table.ForeignKey(
                        name: "FK_CreditNotes_InvoiceDates_InvoiceDateInvoiceId",
                        column: x => x.InvoiceDateInvoiceId,
                        principalTable: "InvoiceDates",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInstallments",
                columns: table => new
                {
                    CustomerInstallmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoicId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDateInvoiceId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Paymentmode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInstallments", x => x.CustomerInstallmentId);
                    table.ForeignKey(
                        name: "FK_CustomerInstallments_InvoiceDates_InvoiceDateInvoiceId",
                        column: x => x.InvoiceDateInvoiceId,
                        principalTable: "InvoiceDates",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SellsReturnDetails",
                columns: table => new
                {
                    SellsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDateInvoiceId = table.Column<int>(type: "int", nullable: true),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    InwordstockStockId = table.Column<int>(type: "int", nullable: true),
                    Qty = table.Column<double>(type: "float", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellsReturnDetails", x => x.SellsID);
                    table.ForeignKey(
                        name: "FK_SellsReturnDetails_InvoiceDates_InvoiceDateInvoiceId",
                        column: x => x.InvoiceDateInvoiceId,
                        principalTable: "InvoiceDates",
                        principalColumn: "InvoiceId");
                    table.ForeignKey(
                        name: "FK_SellsReturnDetails_Inwordstocks_InwordstockStockId",
                        column: x => x.InwordstockStockId,
                        principalTable: "Inwordstocks",
                        principalColumn: "StockId");
                });

            migrationBuilder.CreateTable(
                name: "ApplyCredits",
                columns: table => new
                {
                    ApplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditNoteId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDateInvoiceId = table.Column<int>(type: "int", nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyCredits", x => x.ApplyId);
                    table.ForeignKey(
                        name: "FK_ApplyCredits_CreditNotes_CreditNoteId",
                        column: x => x.CreditNoteId,
                        principalTable: "CreditNotes",
                        principalColumn: "CreditId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplyCredits_InvoiceDates_InvoiceDateInvoiceId",
                        column: x => x.InvoiceDateInvoiceId,
                        principalTable: "InvoiceDates",
                        principalColumn: "InvoiceId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplyCredits_CreditNoteId",
                table: "ApplyCredits",
                column: "CreditNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplyCredits_InvoiceDateInvoiceId",
                table: "ApplyCredits",
                column: "InvoiceDateInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CreditNotes_InvoiceDateInvoiceId",
                table: "CreditNotes",
                column: "InvoiceDateInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInstallments_InvoiceDateInvoiceId",
                table: "CustomerInstallments",
                column: "InvoiceDateInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDates_MaterialId",
                table: "InvoiceDates",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Inwordstocks_MaterialId",
                table: "Inwordstocks",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Inwordstocks_PurchaseMasterPurchaseId",
                table: "Inwordstocks",
                column: "PurchaseMasterPurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CategoryId",
                table: "Materials",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseMasters_SupplierId",
                table: "PurchaseMasters",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SellsReturnDetails_InvoiceDateInvoiceId",
                table: "SellsReturnDetails",
                column: "InvoiceDateInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SellsReturnDetails_InwordstockStockId",
                table: "SellsReturnDetails",
                column: "InwordstockStockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplyCredits");

            migrationBuilder.DropTable(
                name: "CustomerInstallments");

            migrationBuilder.DropTable(
                name: "InvoiceMasters");

            migrationBuilder.DropTable(
                name: "SellsReturnDetails");

            migrationBuilder.DropTable(
                name: "CreditNotes");

            migrationBuilder.DropTable(
                name: "Inwordstocks");

            migrationBuilder.DropTable(
                name: "InvoiceDates");

            migrationBuilder.DropTable(
                name: "PurchaseMasters");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
