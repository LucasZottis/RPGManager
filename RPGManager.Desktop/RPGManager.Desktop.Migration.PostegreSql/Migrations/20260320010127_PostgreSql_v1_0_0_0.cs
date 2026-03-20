using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGManager.Desktop.PostgreSql.Migrations
{
    /// <inheritdoc />
    public partial class PostgreSql_v1_0_0_0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "class",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_class", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "game_system",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_game_system", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ability_score",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    abbreviation = table.Column<string>(type: "varchar", maxLength: 3, nullable: true),
                    description = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_ability_score", x => x.id);
                    table.ForeignKey(
                        name: "f_k_ability_score__game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "alignment",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_alignment", x => x.id);
                    table.ForeignKey(
                        name: "f_k_alignment__game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "currency_type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    abbreviation = table.Column<string>(type: "varchar", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_currency_type", x => x.id);
                    table.ForeignKey(
                        name: "f_k_currency_type__game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "damage_type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_damage_type", x => x.id);
                    table.ForeignKey(
                        name: "f_k_damage_type__game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    alphabet = table.Column<string>(type: "varchar", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_language", x => x.id);
                    table.ForeignKey(
                        name: "f_k_language_game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    parent_race_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true),
                    speed = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_race", x => x.id);
                    table.ForeignKey(
                        name: "f_k_race_game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "f_k_race_race_parent_race_id",
                        column: x => x.parent_race_id,
                        principalTable: "race",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "weapon_category",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_weapon_category", x => x.id);
                    table.ForeignKey(
                        name: "f_k_weapon_category_game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_weapon_type", x => x.id);
                    table.ForeignKey(
                        name: "f_k_weapon_type_game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    base_ability_score_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_skill", x => x.id);
                    table.ForeignKey(
                        name: "f_k_skill_ability_score_base_ability_score_id",
                        column: x => x.base_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "f_k_skill_game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_property",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    alternative_ability_score_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true),
                    has_alternative_dice_type_damage = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_weapon_property", x => x.id);
                    table.ForeignKey(
                        name: "f_k_weapon_property_ability_score_alternative_ability_score_id",
                        column: x => x.alternative_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "f_k_weapon_property_game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    base_ability_score_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    currency_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true),
                    price = table.Column<decimal>(type: "decimal", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: false),
                    range_normal = table.Column<float>(type: "real", nullable: true),
                    range_long = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_weapon", x => x.id);
                    table.ForeignKey(
                        name: "f_k_weapon__weapon_category_weapon_category_id",
                        column: x => x.weapon_category_id,
                        principalTable: "weapon_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "f_k_weapon__weapon_type_weapon_type_id",
                        column: x => x.weapon_type_id,
                        principalTable: "weapon_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "f_k_weapon_ability_score_base_ability_score_id",
                        column: x => x.base_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "f_k_weapon_currency_type_currency_type_id",
                        column: x => x.currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "f_k_weapon_game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_properties",
                columns: table => new
                {
                    weapon_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_property_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_weapon_properties", x => new { x.weapon_property_id, x.weapon_id });
                    table.ForeignKey(
                        name: "f_k_weapon_properties__weapon_property_weapon_property_id",
                        column: x => x.weapon_property_id,
                        principalTable: "weapon_property",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "f_k_weapon_properties_weapon_weapon_id",
                        column: x => x.weapon_id,
                        principalTable: "weapon",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ability_score_game_system_id",
                table: "ability_score",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_alignment_game_system_id",
                table: "alignment",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_currency_type_game_system_id",
                table: "currency_type",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_damage_type_game_system_id",
                table: "damage_type",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_language_game_system_id",
                table: "language",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_game_system_id",
                table: "race",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_parent_race_id",
                table: "race",
                column: "parent_race_id");

            migrationBuilder.CreateIndex(
                name: "IX_skill_base_ability_score_id",
                table: "skill",
                column: "base_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_skill_game_system_id",
                table: "skill",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_base_ability_score_id",
                table: "weapon",
                column: "base_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_currency_type_id",
                table: "weapon",
                column: "currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_game_system_id",
                table: "weapon",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_weapon_category_id",
                table: "weapon",
                column: "weapon_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_weapon_type_id",
                table: "weapon",
                column: "weapon_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_category_game_system_id",
                table: "weapon_category",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_properties_weapon_id",
                table: "weapon_properties",
                column: "weapon_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_property_alternative_ability_score_id",
                table: "weapon_property",
                column: "alternative_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_property_game_system_id",
                table: "weapon_property",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_type_game_system_id",
                table: "weapon_type",
                column: "game_system_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alignment");

            migrationBuilder.DropTable(
                name: "class");

            migrationBuilder.DropTable(
                name: "damage_type");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "race");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "weapon_properties");

            migrationBuilder.DropTable(
                name: "weapon_property");

            migrationBuilder.DropTable(
                name: "weapon");

            migrationBuilder.DropTable(
                name: "weapon_category");

            migrationBuilder.DropTable(
                name: "weapon_type");

            migrationBuilder.DropTable(
                name: "ability_score");

            migrationBuilder.DropTable(
                name: "currency_type");

            migrationBuilder.DropTable(
                name: "game_system");
        }
    }
}
