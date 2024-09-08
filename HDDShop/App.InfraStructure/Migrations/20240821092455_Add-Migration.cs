using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUs_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactUs_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayRules_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayRules_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnRules_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnRules_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rules_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rules_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleRules_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaleRules_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendRules_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendRules_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DeleteItemDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BlogCategoryId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blog_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogCategory_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogCategory_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    Comment_Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Comment_Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Comment_UserId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FaqCategoryId = table.Column<int>(type: "int", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaqCategory_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FaqCategory_Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Video = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Learning_Image = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Learning_Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LearningCategoryId = table.Column<int>(type: "int", nullable: true),
                    LearningCategory_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LearningCategory_Image = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Massage = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    BaseDataMessage_UserId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    SendTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveredTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    link = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    Token = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    SmsCode_PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    SmsCode_UserId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Order_UserId = table.Column<int>(type: "int", nullable: true),
                    SumPrice = table.Column<int>(type: "int", nullable: true),
                    OrderStatus = table.Column<int>(type: "int", nullable: true),
                    OrderDetail_FullName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MelliCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    PostalNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    OrderDetail_PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    OrderDetail_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Portal = table.Column<int>(type: "int", nullable: true),
                    OrderItem_OrderId = table.Column<int>(type: "int", nullable: true),
                    UnitPrice = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    OrderItem_ProductId = table.Column<int>(type: "int", nullable: true),
                    Payment_OrderId = table.Column<int>(type: "int", nullable: true),
                    Payment_UserId = table.Column<int>(type: "int", nullable: true),
                    TransactionNumber = table.Column<int>(type: "int", nullable: true),
                    TransactionHexCode = table.Column<int>(type: "int", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    price = table.Column<long>(type: "bigint", nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: true),
                    PaymentResult = table.Column<int>(type: "int", nullable: true),
                    Favorite_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favorite_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favorite_ShortText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shortlink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favorite_UserId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: true),
                    ProductColorId = table.Column<int>(type: "int", nullable: true),
                    ProductPriceId = table.Column<int>(type: "int", nullable: true),
                    ProductCapacityId = table.Column<int>(type: "int", nullable: true),
                    ProductBrandId = table.Column<int>(type: "int", nullable: true),
                    ShortLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_ShortText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_UserId = table.Column<int>(type: "int", nullable: true),
                    ProductBrand_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCapacity_Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategory_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductColor_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductFeature_ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductGallery_ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductGallery_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyPrice = table.Column<int>(type: "int", nullable: true),
                    SalePrice = table.Column<int>(type: "int", nullable: true),
                    ColeagugePrice = table.Column<int>(type: "int", nullable: true),
                    Benefit = table.Column<int>(type: "int", nullable: true),
                    ProductPrice_ProductId = table.Column<int>(type: "int", nullable: true),
                    Address_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Long = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cityid = table.Column<int>(type: "int", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address_UserId = table.Column<int>(type: "int", nullable: true),
                    OrderList_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderList_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderList_ShortText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderList_Shortlink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderList_Price = table.Column<int>(type: "int", nullable: true),
                    Role_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserRole_UserId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    User_FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    User_Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    User_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    User_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserToken_PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    UserToken_UserId = table.Column<int>(type: "int", nullable: true),
                    UserToken_Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAcvtive = table.Column<bool>(type: "bit", nullable: true),
                    UserToken_ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_BaseDataMessage_UserId",
                        column: x => x.BaseDataMessage_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_BlogCategoryId",
                        column: x => x.BlogCategoryId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Comment_UserId",
                        column: x => x.Comment_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_FaqCategoryId",
                        column: x => x.FaqCategoryId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Favorite_UserId",
                        column: x => x.Favorite_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_LearningCategoryId",
                        column: x => x.LearningCategoryId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_OrderId",
                        column: x => x.OrderId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_OrderItem_OrderId",
                        column: x => x.OrderItem_OrderId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Order_UserId",
                        column: x => x.Order_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Payment_OrderId",
                        column: x => x.Payment_OrderId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Payment_UserId",
                        column: x => x.Payment_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductCapacityId",
                        column: x => x.ProductCapacityId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductColorId",
                        column: x => x.ProductColorId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductFeature_ProductId",
                        column: x => x.ProductFeature_ProductId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductGallery_ProductId",
                        column: x => x.ProductGallery_ProductId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductId",
                        column: x => x.ProductId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductPriceId",
                        column: x => x.ProductPriceId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_ProductPrice_ProductId",
                        column: x => x.ProductPrice_ProductId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_Product_UserId",
                        column: x => x.Product_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_RoleId",
                        column: x => x.RoleId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_SmsCode_UserId",
                        column: x => x.SmsCode_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_UserId",
                        column: x => x.UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_UserRole_UserId",
                        column: x => x.UserRole_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntities_BaseEntities_UserToken_UserId",
                        column: x => x.UserToken_UserId,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_BaseDataMessage_UserId",
                table: "BaseEntities",
                column: "BaseDataMessage_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_BlogCategoryId",
                table: "BaseEntities",
                column: "BlogCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Comment_UserId",
                table: "BaseEntities",
                column: "Comment_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_FaqCategoryId",
                table: "BaseEntities",
                column: "FaqCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Favorite_UserId",
                table: "BaseEntities",
                column: "Favorite_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_LearningCategoryId",
                table: "BaseEntities",
                column: "LearningCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Order_UserId",
                table: "BaseEntities",
                column: "Order_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_OrderId",
                table: "BaseEntities",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_OrderItem_OrderId",
                table: "BaseEntities",
                column: "OrderItem_OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Payment_OrderId",
                table: "BaseEntities",
                column: "Payment_OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Payment_UserId",
                table: "BaseEntities",
                column: "Payment_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_Product_UserId",
                table: "BaseEntities",
                column: "Product_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductBrandId",
                table: "BaseEntities",
                column: "ProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductCapacityId",
                table: "BaseEntities",
                column: "ProductCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductCategoryId",
                table: "BaseEntities",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductColorId",
                table: "BaseEntities",
                column: "ProductColorId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductFeature_ProductId",
                table: "BaseEntities",
                column: "ProductFeature_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductGallery_ProductId",
                table: "BaseEntities",
                column: "ProductGallery_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductId",
                table: "BaseEntities",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductPrice_ProductId",
                table: "BaseEntities",
                column: "ProductPrice_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_ProductPriceId",
                table: "BaseEntities",
                column: "ProductPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_RoleId",
                table: "BaseEntities",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_SmsCode_UserId",
                table: "BaseEntities",
                column: "SmsCode_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_UserId",
                table: "BaseEntities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_UserRole_UserId",
                table: "BaseEntities",
                column: "UserRole_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntities_UserToken_UserId",
                table: "BaseEntities",
                column: "UserToken_UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntities");
        }
    }
}
