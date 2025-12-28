using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGManager.Desktop.SqLite.Migrations
{
    /// <inheritdoc />
    public partial class SqLite_v1_0_0_0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameSystem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbilityScore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    Abbreviation = table.Column<string>(type: "text", maxLength: 3, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbilityScore_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alignment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alignment_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyTpe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    Abbreviation = table.Column<string>(type: "text", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyTpe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrencyTpe_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DamageType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DamageType_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    Alphabet = table.Column<string>(type: "text", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Language_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponCategory_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    AlterantiveAbilityScoreId = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    HasAlternativeDiceTypeDamage = table.Column<bool>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponProperty_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponType_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    BaseAbilityScoreId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_AbilityScore_BaseAbilityScoreId",
                        column: x => x.BaseAbilityScoreId,
                        principalTable: "AbilityScore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Skill_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "text(36)", nullable: false),
                    GameSystemId = table.Column<Guid>(type: "text(36)", nullable: false),
                    WeaponCategoryId = table.Column<Guid>(type: "text(36)", nullable: false),
                    WeaponTypeId = table.Column<Guid>(type: "text(36)", nullable: false),
                    BaseAbilityScoreId = table.Column<Guid>(type: "text(36)", nullable: false),
                    AlternativeAbilityScoreId = table.Column<Guid>(type: "text(36)", nullable: true),
                    CurrencyTypeId = table.Column<Guid>(type: "text(36)", nullable: false),
                    Name = table.Column<string>(type: "text", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    RangeNormal = table.Column<float>(type: "REAL", nullable: true),
                    RangeLong = table.Column<float>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapon_AbilityScore_AlternativeAbilityScoreId",
                        column: x => x.AlternativeAbilityScoreId,
                        principalTable: "AbilityScore",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Weapon_AbilityScore_BaseAbilityScoreId",
                        column: x => x.BaseAbilityScoreId,
                        principalTable: "AbilityScore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weapon_CurrencyTpe_CurrencyTypeId",
                        column: x => x.CurrencyTypeId,
                        principalTable: "CurrencyTpe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weapon_GameSystem_GameSystemId",
                        column: x => x.GameSystemId,
                        principalTable: "GameSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weapon_WeaponCategory_WeaponCategoryId",
                        column: x => x.WeaponCategoryId,
                        principalTable: "WeaponCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weapon_WeaponType_WeaponTypeId",
                        column: x => x.WeaponTypeId,
                        principalTable: "WeaponType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponProperties",
                columns: table => new
                {
                    WeaponId = table.Column<Guid>(type: "text(36)", nullable: false),
                    WeaponPropertyId = table.Column<Guid>(type: "text(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponProperties", x => new { x.WeaponPropertyId, x.WeaponId });
                    table.ForeignKey(
                        name: "FK_WeaponProperties_WeaponProperty_WeaponPropertyId",
                        column: x => x.WeaponPropertyId,
                        principalTable: "WeaponProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponProperties_Weapon_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScore_GameSystemId",
                table: "AbilityScore",
                column: "GameSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Alignment_GameSystemId",
                table: "Alignment",
                column: "GameSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyTpe_GameSystemId",
                table: "CurrencyTpe",
                column: "GameSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageType_GameSystemId",
                table: "DamageType",
                column: "GameSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_GameSystemId",
                table: "Language",
                column: "GameSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_BaseAbilityScoreId",
                table: "Skill",
                column: "BaseAbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_GameSystemId",
                table: "Skill",
                column: "GameSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_AlternativeAbilityScoreId",
                table: "Weapon",
                column: "AlternativeAbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_BaseAbilityScoreId",
                table: "Weapon",
                column: "BaseAbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_CurrencyTypeId",
                table: "Weapon",
                column: "CurrencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_GameSystemId",
                table: "Weapon",
                column: "GameSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_WeaponCategoryId",
                table: "Weapon",
                column: "WeaponCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_WeaponTypeId",
                table: "Weapon",
                column: "WeaponTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponCategory_GameSystemId",
                table: "WeaponCategory",
                column: "GameSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponProperties_WeaponId",
                table: "WeaponProperties",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponProperty_GameSystemId",
                table: "WeaponProperty",
                column: "GameSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponType_GameSystemId",
                table: "WeaponType",
                column: "GameSystemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alignment");

            migrationBuilder.DropTable(
                name: "DamageType");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "WeaponProperties");

            migrationBuilder.DropTable(
                name: "WeaponProperty");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "AbilityScore");

            migrationBuilder.DropTable(
                name: "CurrencyTpe");

            migrationBuilder.DropTable(
                name: "WeaponCategory");

            migrationBuilder.DropTable(
                name: "WeaponType");

            migrationBuilder.DropTable(
                name: "GameSystem");
        }
    }
}
