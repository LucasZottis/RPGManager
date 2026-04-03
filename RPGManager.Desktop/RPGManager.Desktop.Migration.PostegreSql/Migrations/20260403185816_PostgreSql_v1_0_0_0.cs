using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RPGManager.Desktop.PostgreSql.Migrations
{
    /// <inheritdoc />
    public partial class PostgreSql_v1_0_0_0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dice_type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    sides = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_dice_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "game_system",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    level_limit = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_game_system", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_role", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 150, nullable: false),
                    email = table.Column<string>(type: "varchar", maxLength: 320, nullable: false),
                    password_hash = table.Column<string>(type: "varchar", maxLength: 60, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2026, 4, 3, 15, 58, 15, 678, DateTimeKind.Local).AddTicks(6241))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "game_system_version",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    version = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    legal_information = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_game_system_version", x => x.id);
                    table.ForeignKey(
                        name: "fk_game_system_version_game_system_game_system_id",
                        column: x => x.game_system_id,
                        principalTable: "game_system",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_role",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    role_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_role", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "fk_user_role_role_role_id",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_role_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ability_score",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    abbreviation = table.Column<string>(type: "varchar", maxLength: 3, nullable: true),
                    description = table.Column<string>(type: "varchar", nullable: true),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ability_score", x => x.id);
                    table.ForeignKey(
                        name: "fk_ability_score_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "alignment",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_alignment", x => x.id);
                    table.ForeignKey(
                        name: "fk_alignment_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "armor_category",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_armor_category", x => x.id);
                    table.ForeignKey(
                        name: "fk_armor_category_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "currency_type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    abbreviation = table.Column<string>(type: "varchar", maxLength: 5, nullable: true),
                    is_base_currency = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_currency_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_currency_type_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "damage_type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_damage_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_damage_type_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "language",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    alphabet = table.Column<string>(type: "varchar", maxLength: 20, nullable: true),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_language", x => x.id);
                    table.ForeignKey(
                        name: "fk_language_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "level",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    level_number = table.Column<byte>(type: "smallint", nullable: false),
                    experience_points = table.Column<long>(type: "bigint", nullable: false),
                    proficiency_bonus = table.Column<byte>(type: "smallint", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_level", x => x.id);
                    table.ForeignKey(
                        name: "fk_level_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    min_height = table.Column<float>(type: "real", nullable: false),
                    max_height = table.Column<float>(type: "real", nullable: true),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_size", x => x.id);
                    table.ForeignKey(
                        name: "fk_size_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tool_category",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tool_category", x => x.id);
                    table.ForeignKey(
                        name: "fk_tool_category_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_category",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_category", x => x.id);
                    table.ForeignKey(
                        name: "fk_weapon_category_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_mastery_property",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_mastery_property", x => x.id);
                    table.ForeignKey(
                        name: "fk_weapon_mastery_property_game_system_version_game_system_ver~",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_weapon_type_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    base_ability_score_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_skill", x => x.id);
                    table.ForeignKey(
                        name: "fk_skill_ability_score_base_ability_score_id",
                        column: x => x.base_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_skill_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_property",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    alternative_ability_score_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true),
                    has_alternative_dice_type_damage = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_property", x => x.id);
                    table.ForeignKey(
                        name: "fk_weapon_property_ability_score_alternative_ability_score_id",
                        column: x => x.alternative_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_weapon_property_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ammunition_type",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    amount = table.Column<byte>(type: "smallint", nullable: false),
                    storage = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cost_currency_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    cost = table.Column<decimal>(type: "decimal", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_ammunition_type", x => x.id);
                    table.ForeignKey(
                        name: "fk_ammunition_type_currency_type_cost_currency_type_id",
                        column: x => x.cost_currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_ammunition_type_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "currency_conversion_rate",
                columns: table => new
                {
                    from_currency_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    to_currency_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    rate = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_currency_conversion_rate", x => new { x.from_currency_type_id, x.to_currency_type_id });
                    table.ForeignKey(
                        name: "fk_currency_conversion_rate_currency_type_from_currency_type_id",
                        column: x => x.from_currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_currency_conversion_rate_currency_type_to_currency_type_id",
                        column: x => x.to_currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gear",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cost_currency_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    cost = table.Column<decimal>(type: "decimal", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_gear", x => x.id);
                    table.ForeignKey(
                        name: "fk_gear_currency_type_cost_currency_type_id",
                        column: x => x.cost_currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_gear_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shield_armor",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    armor_class_bonus = table.Column<byte>(type: "smallint", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cost_currency_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    cost = table.Column<decimal>(type: "decimal", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: true),
                    armor_category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    required_ability_score_id = table.Column<Guid>(type: "uuid", nullable: true),
                    required_ability_score_minimum = table.Column<byte>(type: "smallint", nullable: false),
                    disadvantage_on_stealth = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_shield_armor", x => x.id);
                    table.ForeignKey(
                        name: "fk_shield_armor_ability_score_required_ability_score_id",
                        column: x => x.required_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_shield_armor_armor_category_armor_category_id",
                        column: x => x.armor_category_id,
                        principalTable: "armor_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_shield_armor_currency_type_cost_currency_type_id",
                        column: x => x.cost_currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_shield_armor_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wearable_armor",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    armor_class_ability_score_modifier_id = table.Column<Guid>(type: "uuid", nullable: true),
                    base_armor_class = table.Column<byte>(type: "smallint", nullable: false),
                    applies_ability_modifier = table.Column<bool>(type: "boolean", nullable: false),
                    max_ability_modifier = table.Column<byte>(type: "smallint", nullable: true),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cost_currency_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    cost = table.Column<decimal>(type: "decimal", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: true),
                    armor_category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    required_ability_score_id = table.Column<Guid>(type: "uuid", nullable: true),
                    required_ability_score_minimum = table.Column<byte>(type: "smallint", nullable: false),
                    disadvantage_on_stealth = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_wearable_armor", x => x.id);
                    table.ForeignKey(
                        name: "fk_wearable_armor_ability_score_armor_class_ability_score_modi~",
                        column: x => x.armor_class_ability_score_modifier_id,
                        principalTable: "ability_score",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_wearable_armor_ability_score_required_ability_score_id",
                        column: x => x.required_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_wearable_armor_armor_category_armor_category_id",
                        column: x => x.armor_category_id,
                        principalTable: "armor_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_wearable_armor_currency_type_cost_currency_type_id",
                        column: x => x.cost_currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_wearable_armor_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tool",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    tool_category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    check_ability_score_id = table.Column<Guid>(type: "uuid", nullable: false),
                    utilize = table.Column<string>(type: "varchar", nullable: false),
                    craft = table.Column<string>(type: "varchar", nullable: true),
                    variants = table.Column<string>(type: "varchar", nullable: true),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cost_currency_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    cost = table.Column<decimal>(type: "decimal", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tool", x => x.id);
                    table.ForeignKey(
                        name: "fk_tool_ability_score_check_ability_score_id",
                        column: x => x.check_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tool_currency_type_cost_currency_type_id",
                        column: x => x.cost_currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_tool_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_tool_tool_category_tool_category_id",
                        column: x => x.tool_category_id,
                        principalTable: "tool_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_mastery_property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    base_ability_score_id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cost_currency_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    cost = table.Column<decimal>(type: "decimal", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon", x => x.id);
                    table.ForeignKey(
                        name: "fk_weapon_ability_score_base_ability_score_id",
                        column: x => x.base_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weapon_currency_type_cost_currency_type_id",
                        column: x => x.cost_currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_weapon_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weapon_weapon_category_weapon_category_id",
                        column: x => x.weapon_category_id,
                        principalTable: "weapon_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weapon_weapon_mastery_property_weapon_mastery_property_id",
                        column: x => x.weapon_mastery_property_id,
                        principalTable: "weapon_mastery_property",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weapon_weapon_type_weapon_type_id",
                        column: x => x.weapon_type_id,
                        principalTable: "weapon_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_damage",
                columns: table => new
                {
                    weapon_id = table.Column<Guid>(type: "uuid", nullable: false),
                    damage_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    dice_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    dice_quantity = table.Column<byte>(type: "smallint", nullable: false, defaultValue: (byte)1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_damage", x => new { x.weapon_id, x.damage_type_id, x.dice_type_id });
                    table.ForeignKey(
                        name: "fk_weapon_damage_damage_type_damage_type_id",
                        column: x => x.damage_type_id,
                        principalTable: "damage_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weapon_damage_dice_type_dice_type_id",
                        column: x => x.dice_type_id,
                        principalTable: "dice_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weapon_damage_weapon_weapon_id",
                        column: x => x.weapon_id,
                        principalTable: "weapon",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_property_attribute",
                columns: table => new
                {
                    weapon_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ammunition_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    normal_range = table.Column<float>(type: "real", nullable: true),
                    long_range = table.Column<float>(type: "real", nullable: true),
                    remarks = table.Column<string>(type: "varchar", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_property_attribute", x => new { x.weapon_id, x.weapon_property_id });
                    table.ForeignKey(
                        name: "fk_weapon_property_attribute_ammunition_type_ammunition_type_id",
                        column: x => x.ammunition_type_id,
                        principalTable: "ammunition_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_weapon_property_attribute_weapon_property_weapon_property_id",
                        column: x => x.weapon_property_id,
                        principalTable: "weapon_property",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weapon_property_attribute_weapon_weapon_id",
                        column: x => x.weapon_id,
                        principalTable: "weapon",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "dice_type",
                columns: new[] { "id", "name", "sides" },
                values: new object[,]
                {
                    { new Guid("049b9edf-f128-4286-a327-d0124d790775"), "D4", (byte)4 },
                    { new Guid("18cedc29-1808-4739-982d-bc8a74613d6c"), "D12", (byte)12 },
                    { new Guid("2cef9049-c6e4-4e05-875f-f38de5e19416"), "D100", (byte)100 },
                    { new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), "D8", (byte)8 },
                    { new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), "D6", (byte)6 },
                    { new Guid("bcd3346f-6f8c-4de8-91b1-1ffbab5f92c0"), "D20", (byte)20 },
                    { new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), "D10", (byte)10 }
                });

            migrationBuilder.InsertData(
                table: "game_system",
                columns: new[] { "id", "level_limit", "name" },
                values: new object[] { new Guid("55b66976-7cea-4e52-90b3-3033e5a1ae70"), (byte)0, "Dungeons & Dragons" });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("979f88f6-047e-4728-a27f-83bf5f6d01e4"), "Role with limited permissions.", "Admin" },
                    { new Guid("9ca509b7-1ebf-4e80-98ab-9ba3daee5701"), "Role with all permissions.", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "email", "name", "password_hash" },
                values: new object[] { new Guid("0ac4e2e7-ba42-4576-a6c9-8cb7dba21b18"), "JECKC9/2rjcLNKWpgmjR1Q==", "IOJBj9szK9e3gUqfpF2J6w==", "$2a$11$CZttVsn0PhxiwNPZsDmHluwtEc3kSZg4k3vJb9u07XkpB.PFlioQm" });

            migrationBuilder.InsertData(
                table: "game_system_version",
                columns: new[] { "id", "game_system_id", "legal_information", "version" },
                values: new object[] { new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), new Guid("55b66976-7cea-4e52-90b3-3033e5a1ae70"), null, "5.2.1" });

            migrationBuilder.InsertData(
                table: "user_role",
                columns: new[] { "role_id", "user_id" },
                values: new object[] { new Guid("9ca509b7-1ebf-4e80-98ab-9ba3daee5701"), new Guid("0ac4e2e7-ba42-4576-a6c9-8cb7dba21b18") });

            migrationBuilder.InsertData(
                table: "ability_score",
                columns: new[] { "id", "abbreviation", "description", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("151e6233-d307-47c5-ab78-fff32cd510a0"), "CAR", "Carisma mede a confiança, a postura e o charme de um personagem.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Carisma" },
                    { new Guid("6ba5e150-fe51-46d4-af2c-1d101108eb7f"), "INT", "Inteligência mede o raciocínio e a capacidade de memorização de um personagem.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Inteligência" },
                    { new Guid("776e8837-3b8e-4533-86b3-ca72f50a15fe"), "SAB", "Sabedoria mede a percepção e a resistência mental de um personagem.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Sabedoria" },
                    { new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), "DES", "Destreza mede a agilidade, os reflexos e o equilíbrio de um personagem.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Destreza" },
                    { new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), "FOR", "Força mede o poder muscular, a capacidade de carregar peso e a potência física geral de um personagem.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Força" },
                    { new Guid("dfa7b377-942a-42d8-9c28-d467744d9556"), "CON", "Constituição mede a saúde e a resistência física de um personagem.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Constituição" }
                });

            migrationBuilder.InsertData(
                table: "alignment",
                columns: new[] { "id", "description", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("0bcc693d-2d08-4197-81c8-8af2e0ae0ec2"), "Criaturas Caóticas e Más agem com violência arbitrária, impulsionadas pelo ódio ou sede de sangue. Um vilão que persegue esquemas de vingança e caos provavelmente é Caótico e Mau.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Caótico e Mau" },
                    { new Guid("10779552-57c2-4dbd-bf5c-7fd5767748e6"), "Criaturas Caóticas e Neutras seguem seus caprichos, valorizando a liberdade pessoal acima de tudo. Um vagabundo que percorre a terra vivendo de esperteza provavelmente é Caótico e Neutro.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Caótico e Neutro" },
                    { new Guid("4a43d257-87b7-4ae1-8c1a-30b432e49a89"), "Criaturas Caóticas e Boas agem conforme sua consciência, com pouca consideração pelo que os outros esperam. Um rebelde que usa recursos roubados de tiranos para ajudar os pobres provavelmente é Caótico e Bom.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Caótico e Bom" },
                    { new Guid("56eb32ca-072a-448b-accf-17dc77f31e8e"), "Neutro e Mau é o alinhamento de quem não se incomoda com o mal que causa ao perseguir seus desejos. Um criminoso que rouba e mata à vontade provavelmente é Neutro e Mau.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Neutro e Mau" },
                    { new Guid("57c52568-a3b8-491a-ae20-c82fbec54447"), "Criaturas Leais e Boas se esforçam para fazer a coisa certa conforme o esperado pela sociedade. Alguém que combate a injustiça e protege os inocentes sem hesitação provavelmente é Leal e Bom.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Leal e Bom" },
                    { new Guid("59a219de-4be6-409b-973c-de485faf696f"), "Criaturas Leais e Más tomam metodicamente o que desejam dentro dos limites de um código de tradição, lealdade ou ordem. Um aristocrata que explora cidadãos enquanto trama pelo poder provavelmente é Leal e Mau.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Leal e Mau" },
                    { new Guid("b25c3311-a862-4a9f-918b-d97ef5c6273f"), "Criaturas Neutras e Boas fazem o melhor que podem, trabalhando dentro das regras sem se sentirem limitadas por elas. Uma pessoa gentil que ajuda os outros conforme as necessidades provavelmente é Neutra e Boa.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Neutro e Bom" },
                    { new Guid("c21ab474-ae19-4188-858c-7faa86225bf8"), "Indivíduos Leais e Neutros agem de acordo com a lei, a tradição ou códigos pessoais. Alguém que segue uma disciplina rigorosa de vida sem se deixar influenciar pelos necessitados nem pelas tentações do mal provavelmente é Leal e Neutro.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Leal e Neutro" },
                    { new Guid("ed38d4e2-3b2b-4606-b1ba-5862b7a7b7f9"), "Neutro é o alinhamento de quem prefere evitar questões morais e não toma partido, fazendo o que parece melhor no momento. Alguém entediado por debates morais provavelmente é Neutro.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Neutro" }
                });

            migrationBuilder.InsertData(
                table: "armor_category",
                columns: new[] { "id", "description", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("6125d19e-20f6-4333-8b5a-4408021150bd"), "Armaduras leves são projetadas para aventureiros ágeis, pois oferecem proteção sem sacrificar a mobilidade. Vestir ou remover uma armadura leve leva 1 minuto.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Leve" },
                    { new Guid("626c8290-d046-462c-ab83-19c84917ab06"), "Armaduras pesadas oferecem a maior proteção, mas exigem força para suportá-las com eficiência. Vestir uma armadura pesada leva 10 minutos e removê-la leva 5 minutos.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pesada" },
                    { new Guid("f96ce39f-902b-431f-bec5-2de186cdead8"), "Um escudo é carregado em uma das mãos e concede um bônus à Classe de Armadura. Apenas quem tem treinamento com escudos recebe esse bônus. Vestir ou remover um escudo requer a ação Utilizar.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Escudo" },
                    { new Guid("f9cae1d9-32a1-4a80-abce-995319ad42ef"), "Armaduras médias oferecem mais proteção do que as leves, mas também prejudicam um pouco o movimento. Vestir uma armadura média leva 5 minutos e removê-la leva 1 minuto.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Média" }
                });

            migrationBuilder.InsertData(
                table: "currency_type",
                columns: new[] { "id", "abbreviation", "game_system_version_id", "name" },
                values: new object[] { new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "PC", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Peça de Cobre" });

            migrationBuilder.InsertData(
                table: "currency_type",
                columns: new[] { "id", "abbreviation", "game_system_version_id", "is_base_currency", "name" },
                values: new object[] { new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "PO", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), true, "Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "currency_type",
                columns: new[] { "id", "abbreviation", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "PP", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Peça de Prata" },
                    { new Guid("ab0595c2-4bb7-4385-aa9d-d78bca78659b"), "PPt", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Peça de Platina" },
                    { new Guid("c5931098-7490-4a1a-b64d-6defc180dbe1"), "PE", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Peça de Electrum" }
                });

            migrationBuilder.InsertData(
                table: "damage_type",
                columns: new[] { "id", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Perfuração" },
                    { new Guid("062dd401-f873-4744-98e2-a4c0233f0b42"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Fogo" },
                    { new Guid("4a281bd6-ed78-40cf-8b11-564805034905"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Radiante" },
                    { new Guid("5cb4df8e-67da-4909-95cc-5690568acf54"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Elétrico" },
                    { new Guid("618f70ad-0ee1-475d-a3cf-faaecffbe6f8"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Veneno" },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Concussão" },
                    { new Guid("9cf410b1-90c2-443b-92da-7e7fcd024a8b"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Ácido" },
                    { new Guid("a62dae73-ebb7-4010-8d0c-f0d0634ae68b"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Necrótico" },
                    { new Guid("c48c8b2d-d633-4603-91cd-fd26354206d0"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Psíquico" },
                    { new Guid("cab6abd8-80c7-43fc-9a7f-c03e5bd813de"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Frio" },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Corte" },
                    { new Guid("d4edcbb9-9ae8-43b2-ba8f-c2769f01ea03"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Força" },
                    { new Guid("d79a3ca0-850c-4bed-ac4c-435f0cf3cfa6"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Trovão" }
                });

            migrationBuilder.InsertData(
                table: "language",
                columns: new[] { "id", "alphabet", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("0670ed3d-a43b-4bfb-b7ce-59df04ca2b14"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Silvano" },
                    { new Guid("07aa5031-f1ba-4c6f-8592-ebff24c9d4d9"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Halfling" },
                    { new Guid("0fdcc53f-238d-4777-9dee-bb592237122d"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Goblin" },
                    { new Guid("1c8a7b93-5396-4abd-9682-5a8dc79a9ef7"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Celestial" },
                    { new Guid("1d6efe22-f09a-4565-a1fc-36bbb219474d"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Primordial" },
                    { new Guid("23e7ccb8-9998-442e-96d2-19cf80412a0f"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Gnômico" },
                    { new Guid("2466ea36-4318-4eca-a61a-ab82110bb218"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Dracônico" },
                    { new Guid("441e8752-29f5-41d1-b5f6-dd6a48e114c6"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Gigante" },
                    { new Guid("4dad01b8-5b99-4e20-bdd4-b6dd37b06dc0"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Élfico" },
                    { new Guid("4e218862-4803-483f-a8ee-ddad4531f387"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Gíria dos Ladrões" },
                    { new Guid("5abe6da9-6dc7-4b74-9520-4f6e90f7743d"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Subcomum" },
                    { new Guid("6c8d2443-f163-4e34-8ec9-e73af648911b"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Língua de Sinais Comum" },
                    { new Guid("82e20589-ce1d-483b-a1d8-9039704f8a62"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Orc" },
                    { new Guid("84ac4ec7-d999-4a37-93fe-235bc549049c"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Anão" },
                    { new Guid("8ad2507a-533b-47eb-aa21-e83fd5bcb66d"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Língua Profunda" },
                    { new Guid("8df9f02f-c358-44fe-b5f7-4d790b2acae4"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Comum" },
                    { new Guid("cf3ee53f-d80c-4a72-8234-f55d1ffacbe6"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Infernal" },
                    { new Guid("d133591f-65dc-4bab-bd6a-bcc287de69f8"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Abissal" },
                    { new Guid("e682ced5-9c61-4459-b175-73c684d6fd9b"), null, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Druídico" }
                });

            migrationBuilder.InsertData(
                table: "level",
                columns: new[] { "id", "experience_points", "game_system_version_id", "level_number", "proficiency_bonus" },
                values: new object[,]
                {
                    { new Guid("02b68ca0-1b8c-46d4-8a71-3d6c2651dd1e"), 23000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)7, (byte)3 },
                    { new Guid("0df4e1a8-12c2-4ecf-947f-6f7a1e13fdfd"), 0L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)1, (byte)2 },
                    { new Guid("12e68a89-25b5-4196-a8f0-59c92f73b2c7"), 120000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)13, (byte)5 },
                    { new Guid("24711fb3-0742-421b-a352-ae1f6dbf8fe2"), 14000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)6, (byte)3 },
                    { new Guid("282a9cb3-c9c7-4e72-80aa-6e75dac80788"), 6500L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)5, (byte)3 },
                    { new Guid("40023840-ab0b-4987-9a84-3b5ce02210db"), 300L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)2, (byte)2 },
                    { new Guid("458f98c6-b445-4d1c-b93e-09e7a4425d5b"), 100000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)12, (byte)4 },
                    { new Guid("49f51d53-9123-42e0-b8ff-78dfbc91a2fe"), 225000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)17, (byte)6 },
                    { new Guid("50e77b48-730b-46aa-bd9f-6457e83bd670"), 900L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)3, (byte)2 },
                    { new Guid("611ff88e-2c23-424a-89de-519bf22e30ed"), 85000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)11, (byte)4 },
                    { new Guid("7496160d-cf02-4ac0-bb0e-6000eaef09da"), 34000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)8, (byte)3 },
                    { new Guid("8477fa39-41ce-48bd-827a-03b9fce3a2e1"), 265000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)18, (byte)6 },
                    { new Guid("9596496b-56b8-4b91-bc15-d738f0ced828"), 195000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)16, (byte)5 },
                    { new Guid("b8840cf5-bad5-4ea1-86f6-4e9048ec1ebf"), 64000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)10, (byte)4 },
                    { new Guid("c6af8b07-7eda-4faa-868c-6f6146559d79"), 140000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)14, (byte)5 },
                    { new Guid("e26bbd7b-aea5-467f-a0bc-718360d5d8b3"), 165000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)15, (byte)5 },
                    { new Guid("e37d7ec8-5345-4c72-b4a6-3004a46dc4f5"), 2700L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)4, (byte)2 },
                    { new Guid("e416b562-b405-4258-94ee-9ea9566a52ac"), 48000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)9, (byte)4 },
                    { new Guid("ee44b648-86d3-45ec-8d4f-a6013ddbd73a"), 305000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)19, (byte)6 },
                    { new Guid("f25ed65b-cdee-4a27-8e23-6fe5f3b3ffdd"), 355000L, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)20, (byte)6 }
                });

            migrationBuilder.InsertData(
                table: "size",
                columns: new[] { "id", "game_system_version_id", "max_height", "min_height", "name" },
                values: new object[,]
                {
                    { new Guid("1fce48d8-4aa8-4c1c-8af0-e98f290a50e2"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), null, 7.3f, "Descomunal" },
                    { new Guid("4a8cba8e-3f32-44c5-bbe9-a24a14c715d7"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), 4.9f, 2.45f, "Grande" },
                    { new Guid("509dda15-4789-4513-9edd-a34a76868eb1"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), 1.2f, 0.6f, "Pequeno" },
                    { new Guid("7f33511a-fe93-42ce-8cb6-c4bd21b1c189"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), 0.6f, 0f, "Minúsculo" },
                    { new Guid("b457cba2-09ff-4976-9969-00f015f4ff80"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), 7.3f, 4.9f, "Enorme" },
                    { new Guid("f9b29fdd-2b54-46f6-b3fc-20970efd8199"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), 2.45f, 1.2f, "Médio" }
                });

            migrationBuilder.InsertData(
                table: "weapon_category",
                columns: new[] { "id", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Marcial" },
                    { new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Simples" }
                });

            migrationBuilder.InsertData(
                table: "weapon_mastery_property",
                columns: new[] { "id", "description", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("008399a1-f923-4c70-a37b-42a4ac2d60bf"), "Se você acertar e causar dano a uma criatura com esta arma, tem Vantagem no próximo ataque contra ela antes do fim do seu próximo turno.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Irritar" },
                    { new Guid("35d851a8-b212-49c9-b709-c41014c60e40"), "Se você acertar e causar dano com esta arma, pode reduzir a Velocidade do alvo em 3 m até o início do seu próximo turno. Múltiplos acertos não acumulam a redução além de 3 m.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Lentidão" },
                    { new Guid("38817c5e-a384-4f8f-bc13-f088b9370769"), "Ao realizar o ataque extra concedido pela propriedade Leve, você pode fazê-lo como parte da ação de Ataque em vez de uma Ação Bônus.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Golpe Extra" },
                    { new Guid("4420b7a1-2fdd-47f0-b32a-f35d13e9974d"), "Se o seu ataque com esta arma errar uma criatura, você pode causar dano igual ao modificador de habilidade usado no ataque. O tipo de dano é o mesmo da arma.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Raspão" },
                    { new Guid("b48306f5-a709-4ac4-9eec-f043ed563347"), "Se você acertar uma criatura com esta arma, ela tem Desvantagem no próximo ataque antes do início do seu próximo turno.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Atordoar" },
                    { new Guid("ceb10c65-cc41-4605-84b0-6b123f2cc825"), "Se você acertar uma criatura com esta arma, pode empurrá-la até 3 m diretamente para longe de você, se ela for Grande ou menor.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Empurrão" },
                    { new Guid("f119f390-5d70-49ba-b520-289d9bbf272e"), "Se você acertar uma criatura com esta arma, pode forçá-la a realizar um teste de resistência de Constituição (CD 8 + modificador de habilidade + bônus de proficiência). Em caso de falha, a criatura fica Prostrada.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Derrubar" },
                    { new Guid("f80143e5-99ec-48f2-acec-6aeb47ee2069"), "Se você acertar uma criatura com um ataque corpo a corpo usando esta arma, pode fazer outro ataque corpo a corpo contra uma segunda criatura a até 1,5 m da primeira e dentro do seu alcance. No acerto, a segunda criatura sofre o dano da arma, sem adicionar o modificador de habilidade, a menos que seja negativo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Corte" }
                });

            migrationBuilder.InsertData(
                table: "weapon_property",
                columns: new[] { "id", "alternative_ability_score_id", "description", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("12036b7e-0da3-446a-a955-f7cc1d87198e"), null, "Ao realizar a ação de Ataque com uma arma Leve, você pode fazer um ataque extra como Ação Bônus com uma arma Leve diferente. Você não adiciona o modificador de habilidade ao dano do ataque bônus, a menos que seja negativo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Leve" },
                    { new Guid("18bb11e5-225e-471a-aa85-2b76d1a9e51d"), null, "Uma arma com a propriedade Alcance lista dois números entre parênteses: o alcance normal e o alcance longo. Atacar além do alcance normal impõe Desvantagem. Você não pode atacar além do alcance longo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Alcance" },
                    { new Guid("399ccecc-0e45-440e-a4c0-4056be0b5bf4"), null, "Você pode disparar apenas uma peça de munição de uma arma com Carregamento ao usar uma ação, Ação Bônus ou Reação, independentemente do número de ataques que normalmente pode fazer.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Carregamento" },
                    { new Guid("3cf4244f-559c-4c6a-b1b1-531dce23d615"), null, "Uma arma com Longo Alcance adiciona 1,5 m ao seu alcance ao atacar com ela, inclusive para Ataques de Oportunidade.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Longo Alcance" },
                    { new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, "Uma arma com Duas Mãos requer as duas mãos para atacar com ela.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Duas Mãos" }
                });

            migrationBuilder.InsertData(
                table: "weapon_property",
                columns: new[] { "id", "alternative_ability_score_id", "description", "game_system_version_id", "has_alternative_dice_type_damage", "name" },
                values: new object[] { new Guid("4b93f9df-b2a7-4dd9-a432-ade50984b03a"), null, "Uma arma Versátil pode ser usada com uma ou duas mãos. Um valor de dano entre parênteses indica o dano ao usar com duas mãos em um ataque corpo a corpo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), true, "Versátil" });

            migrationBuilder.InsertData(
                table: "weapon_property",
                columns: new[] { "id", "alternative_ability_score_id", "description", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, "Você pode usar uma arma com a propriedade Munição para fazer um ataque à distância somente se tiver munição para disparar. Cada ataque consome uma peça de munição. Após o combate, você pode gastar 1 minuto para recuperar metade da munição usada.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Munição" },
                    { new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, "Você tem Desvantagem em jogadas de ataque com uma arma Pesada se for corpo a corpo e sua Força for menor que 13, ou se for à distância e sua Destreza for menor que 13.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pesada" },
                    { new Guid("fe6d71c8-a79a-46c8-a9dd-8646bf06aae7"), null, "Se uma arma tem a propriedade Arremessável, você pode arremessá-la para fazer um ataque à distância. Se for uma arma corpo a corpo, use o mesmo modificador de habilidade do ataque corpo a corpo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Arremessável" }
                });

            migrationBuilder.InsertData(
                table: "weapon_type",
                columns: new[] { "id", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Corpo a Corpo" },
                    { new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "À Distância" }
                });

            migrationBuilder.InsertData(
                table: "ammunition_type",
                columns: new[] { "id", "amount", "cost", "cost_currency_type_id", "game_system_version_id", "name", "storage", "weight" },
                values: new object[,]
                {
                    { new Guid("5d43f391-2e57-47f0-b29a-abf00e3b1c02"), (byte)20, 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Flecha", "Aljava", 0.05f },
                    { new Guid("945a320a-fecf-4324-94db-a762b2f79a32"), (byte)20, 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Virote", "Case", 0.05f }
                });

            migrationBuilder.InsertData(
                table: "currency_conversion_rate",
                columns: new[] { "from_currency_type_id", "to_currency_type_id", "rate" },
                values: new object[,]
                {
                    { new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), 0.01m },
                    { new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), 0.1m },
                    { new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), new Guid("ab0595c2-4bb7-4385-aa9d-d78bca78659b"), 0.001m },
                    { new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), new Guid("c5931098-7490-4a1a-b64d-6defc180dbe1"), 0.02m },
                    { new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), 100m },
                    { new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), 10m },
                    { new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("ab0595c2-4bb7-4385-aa9d-d78bca78659b"), 0.1m },
                    { new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("c5931098-7490-4a1a-b64d-6defc180dbe1"), 2m },
                    { new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), 10m },
                    { new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), 0.1m },
                    { new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), new Guid("ab0595c2-4bb7-4385-aa9d-d78bca78659b"), 0.01m },
                    { new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), new Guid("c5931098-7490-4a1a-b64d-6defc180dbe1"), 0.2m },
                    { new Guid("ab0595c2-4bb7-4385-aa9d-d78bca78659b"), new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), 1000m },
                    { new Guid("ab0595c2-4bb7-4385-aa9d-d78bca78659b"), new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), 10m },
                    { new Guid("ab0595c2-4bb7-4385-aa9d-d78bca78659b"), new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), 100m },
                    { new Guid("ab0595c2-4bb7-4385-aa9d-d78bca78659b"), new Guid("c5931098-7490-4a1a-b64d-6defc180dbe1"), 20m },
                    { new Guid("c5931098-7490-4a1a-b64d-6defc180dbe1"), new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), 50m },
                    { new Guid("c5931098-7490-4a1a-b64d-6defc180dbe1"), new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), 0.5m },
                    { new Guid("c5931098-7490-4a1a-b64d-6defc180dbe1"), new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), 5m },
                    { new Guid("c5931098-7490-4a1a-b64d-6defc180dbe1"), new Guid("ab0595c2-4bb7-4385-aa9d-d78bca78659b"), 0.05m }
                });

            migrationBuilder.InsertData(
                table: "gear",
                columns: new[] { "id", "cost", "cost_currency_type_id", "description", "game_system_version_id", "name", "weight" },
                values: new object[,]
                {
                    { new Guid("036adf33-db58-4ecb-83a6-ca15a68ec949"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Quando tocado como ação de Utilizar, um Sino produz um som que pode ser ouvido a até 18 m.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Sino", 0f },
                    { new Guid("052b2305-9fdb-4389-9534-5942f0eed861"), 5m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "Quando soprado como ação de Utilizar, um Apito de Sinalização produz um som que pode ser ouvido a até 180 m.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Apito de Sinalização", 0f },
                    { new Guid("0f3bffa7-a035-408a-b6a4-aae9a25ba973"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Robe é uma veste longa e fluida.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Robe", 1.81f },
                    { new Guid("0fbd219b-c910-47b3-9c3e-f026534bce55"), 1m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "Uma Tocha queima por 1 hora, emitindo Luz Plena em um raio de 6 m e Luz Fraca por mais 6 m. Ao realizar a ação de Ataque, você pode atacar com a Tocha como arma simples corpo a corpo. No acerto, o alvo sofre 1 de dano de Fogo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Tocha", 0.45f },
                    { new Guid("18474ccb-e42a-4d82-9f5f-6ae45c548306"), 16m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Contém: Mochila, Esferas de Aço, Sino, 10 Velas, Pé de Cabra, Lanterna Encoberta, 7 frascos de Óleo, 5 dias de Rações, Corda, Isqueiro e Cantil.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pacote de Ladrão", 19.05f },
                    { new Guid("1acea3e6-566f-4d1d-8996-8ae88e5dbf1a"), 40m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Contém: Mochila, Saco de Dormir, Sino, Lanterna de Holofote, 3 Fantasias, Espelho, 8 frascos de Óleo, 9 dias de Rações, Isqueiro e Cantil.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pacote de Artista", 29.03f },
                    { new Guid("1dccceba-95a3-4e3b-84a2-4afe0c47338c"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Se você consultar um Mapa preciso, ganha +5 em testes de Sabedoria (Sobrevivência) para encontrar o caminho no lugar representado.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Mapa", 0f },
                    { new Guid("24f7a5b9-6cf2-4470-8183-519dcda7225c"), 25m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Livro contém ficção ou não-ficção. Se você consultar um Livro não-ficção preciso sobre seu tema, ganha +5 em testes de Inteligência (Arcanismo, História, Natureza ou Religião) sobre aquele tema.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Livro", 2.27f },
                    { new Guid("26316a21-d05e-4d21-a624-75c998373d42"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Como ação de Utilizar, você pode espalhar Esferas de Aço de sua bolsa, cobrindo uma área de 3 m² dentro de 1,5 m. Uma criatura que entrar nessa área pela primeira vez em um turno deve ser bem-sucedida em um teste de resistência de Destreza (CD 10) ou ficará Prostrada. Leva 10 minutos para recolher as esferas.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Esferas de Aço", 0.9f },
                    { new Guid("296470dc-1b60-4707-9c72-fe2262f8a2fa"), 50m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma criatura que bebe este frasco de líquido tem Vantagem em testes de resistência contra veneno por 1 hora. Não beneficia Construtos ou Mortos-Vivos.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Antitoxina", 0f },
                    { new Guid("2e09f532-204b-4d4e-866e-259ad923ed80"), 1m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "Uma Escada tem 3 m de altura. Você deve escalar para subir ou descer.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Escada", 6.8f },
                    { new Guid("31ce6306-0957-46d5-84e3-61208c46f3af"), 2m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "Um Cantil comporta até 1,89 litros. Se você não beber água suficiente, corre risco de desidratação.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Cantil", 0.23f },
                    { new Guid("321c69b1-9fc3-4de5-a253-f7b388e17b99"), 4m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "Um Cesto comporta até 18 kg dentro de 0,06 m³.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Cesto", 0.9f },
                    { new Guid("37153a59-2a7e-4f26-aba2-dafde91db516"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Como ação de Utilizar, você pode colocar esta armadilha no chão. Uma criatura que pisar nela deve ser bem-sucedida em um teste de resistência de Destreza (CD 13) ou sofre 1d4 de dano Perfurante e tem sua Velocidade reduzida a 0. Escapar requer um teste de Força bem-sucedido (CD 13) como ação.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Armadilha de Caçador", 2.27f },
                    { new Guid("39402adc-f91a-42cd-b8c4-14ce8429948a"), 1m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "O Pergaminho é feito de couro animal tratado e é durável o suficiente para durar séculos.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pergaminho", 0f },
                    { new Guid("3a316cb4-7f21-4876-a85e-6ed9fd14651b"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Como ação de Utilizar, você pode enrolar uma Corrente em torno de uma criatura relutante a até 1,5 m com a condição Agarrada, Incapacitada ou Restrita, se for bem-sucedido em um teste de Força (CD 13). Escapar da Corrente requer um teste de Destreza bem-sucedido (CD 18). Romper a Corrente requer um teste de Força bem-sucedido (CD 20).", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Corrente", 4.54f },
                    { new Guid("3df8edf9-2441-494e-b0b7-fcdd26e062cc"), 5m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "Um Isqueiro é um pequeno recipiente com pederneira, fuzil e mecha. Usá-lo para acender uma Vela, Lamparina, Lanterna ou Tocha leva uma Ação Bônus. Acender qualquer outro fogo leva 1 minuto.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Isqueiro", 0.45f },
                    { new Guid("43b6cb63-9bed-4ec5-bb01-7e64ca21d7b7"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Estojo de Virotes comporta até 20 Virotes.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Estojo de Virotes", 0.45f },
                    { new Guid("43dd4879-64c6-4bac-b51b-99d183ae38c3"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Corda tem 15 m de comprimento. Uma criatura presa por Corda deve fazer um teste de Destreza bem-sucedido (CD 15) como ação para escapar.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Corda", 2.27f },
                    { new Guid("4beecacc-fc78-49ea-935a-2fa5595e5d2a"), 25m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Bolsa de Componentes é à prova d'água e repleta de compartimentos que guardam todos os Componentes Materiais gratuitos de suas magias.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Bolsa de Componentes", 0.9f },
                    { new Guid("4d15c9dc-8bf6-4ee5-9f0d-039c57b639ed"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Vidro comporta até 0,12 litros.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Vidro", 0f },
                    { new Guid("5187912d-7a62-49a3-8cc9-9669c017c4d9"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Cadeado vem com uma chave. Sem a chave, uma criatura pode usar Ferramentas de Ladrão para abrir o cadeado com um teste de Destreza bem-sucedido (CD 15).", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Cadeado", 0.45f },
                    { new Guid("520d6562-d451-4563-adb9-19b8f3c03730"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Usar um Pé de Cabra concede Vantagem em testes de Força onde a alavanca do Pé de Cabra pode ser aplicada.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pé de Cabra", 2.27f },
                    { new Guid("552e1b36-6e21-4bee-b441-01ef15f53932"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Como ação de Utilizar, você pode espalhar Caltrops de seu saco cobrindo uma área de 1,5 m² dentro de 1,5 m. Uma criatura que entrar nessa área pela primeira vez em um turno deve ser bem-sucedida em um teste de resistência de Destreza (CD 15) ou sofre 1 de dano Perfurante e tem sua Velocidade reduzida a 0 até o início de seu próximo turno.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Caltrops", 0.9f },
                    { new Guid("55f6a7f3-abdb-4bb4-bb06-9417f882664f"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Baú comporta até 0,34 m³ de conteúdo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Baú", 11.34f },
                    { new Guid("58c1a9b0-809a-4aee-bf9d-881b52d32722"), 40m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Contém: Mochila, Livro, Tinta, Pena, Lamparina, 10 frascos de Óleo, 10 folhas de Pergaminho e Isqueiro.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pacote de Estudioso", 18.14f },
                    { new Guid("59493508-53bd-4259-a26f-d3e43ca8ffbe"), 1m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "O Barbante tem 3 m de comprimento. Você pode dar um nó nele como ação de Utilizar.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Barbante", 0f },
                    { new Guid("59d6f9fe-8f05-43cb-92fb-09a9bb37ae35"), 30m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Pergaminho de Magia contém as palavras de um truque. Se a magia estiver na lista de magias da sua classe, você pode ler o pergaminho e conjurá-la. O pergaminho se desintegra quando a conjuração é completada.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pergaminho de Magia (Truque)", 0f },
                    { new Guid("5b125e20-b8d1-4532-b4f7-22c19a9fdd52"), 100m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Lupa concede Vantagem em testes de habilidade para avaliar ou inspecionar um item altamente detalhado.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Lupa", 0f },
                    { new Guid("5e830cff-75a7-4c92-a8b4-46a9abe221a1"), 2m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "Um Jarro comporta até 3,79 litros.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Jarro", 0.9f },
                    { new Guid("624cf621-0764-44a3-b9f9-d3e372809f7c"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "O Perfume vem em um pequeno frasco.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Perfume", 0f },
                    { new Guid("664de4bc-4a47-4ce4-8024-66c1b2e79cf2"), 4m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Você pode usar um Aríete Portátil para arrombar portas. Ao fazê-lo, ganha +4 em testes de Força para esse fim. Outra criatura pode ajudá-lo, concedendo Vantagem neste teste.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Aríete Portátil", 17.24f },
                    { new Guid("69a43e0b-f111-461a-99b8-fd6e2cb379ea"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Roupas de Viajante são vestes resistentes projetadas para viagens em vários ambientes.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Roupas de Viajante", 1.81f },
                    { new Guid("6c8623ce-d86a-45b2-ab11-9e5f9bcbc2a2"), 5m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "Rações consistem em alimentos secos adequados para viagens longas, incluindo carne seca, frutas secas, biscoitos e nozes.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Rações", 0.45f },
                    { new Guid("6f668534-2d7d-4e72-9611-70da9a8133ba"), 50m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Ao realizar a ação de Ataque, você pode substituir um de seus ataques por arremessar um frasco de Fogo de Alquimista. Alvo: uma criatura ou objeto visível a até 6 m. O alvo deve ser bem-sucedido em um teste de resistência de Destreza (CD 8 + modificador de Destreza + bônus de proficiência) ou sofre 1d4 de dano de Fogo e começa a queimar.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Fogo de Alquimista", 0.45f },
                    { new Guid("753eb374-fe06-430b-aa51-372fe68f40b4"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Estacas de Ferro vêm em pacotes de 10. Como ação de Utilizar, você pode usar um objeto contundente para cravar uma estaca em madeira, terra ou material similar. Você pode fazer isso para trancar uma porta ou prender uma Corda ou Corrente à estaca.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Estacas de Ferro", 2.27f },
                    { new Guid("76f7423f-c339-4b99-9384-7b006175ad1a"), 1000m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Objetos vistos através de uma Luneta são ampliados ao dobro de seu tamanho.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Luneta", 0.45f },
                    { new Guid("7813416c-03f5-48f6-84e3-67315a9b91d8"), 15m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Roupas Finas são feitas de tecidos caros e adornadas com detalhes elaborados. Alguns eventos e locais admitem apenas pessoas usando essas roupas.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Roupas Finas", 2.72f },
                    { new Guid("78bfa188-f95d-496c-9de8-c369f2e73b19"), 12m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Contém: Mochila, Caltrops, Pé de Cabra, 2 frascos de Óleo, 10 dias de Rações, Corda, Isqueiro, 10 Tochas e Cantil.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pacote de Explorador de Masmorras", 24.95f },
                    { new Guid("79f90289-8610-4fb4-acf0-8f9d5276048a"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Saco de Dormir acomoda uma criatura Pequena ou Média. Enquanto estiver em um Saco de Dormir, você automaticamente tem sucesso em testes de resistência contra frio extremo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Saco de Dormir", 3.17f },
                    { new Guid("7b1b7d03-7c66-434b-b212-e192fcba7f15"), 5m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "Uma Lamparina queima Óleo como combustível emitindo Luz Plena em um raio de 4,5 m e Luz Fraca por mais 9 m.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Lamparina", 0.45f },
                    { new Guid("7c4bfe25-6702-40be-a6f1-15774581780d"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "A Tinta vem em um frasco de 28 g, que fornece tinta suficiente para escrever cerca de 500 páginas.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Tinta", 0f },
                    { new Guid("7c96baa9-5fef-42e4-a0c8-4d229b96f2b3"), 2m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "Um Frasco comporta até 0,47 litros.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Frasco", 0.45f },
                    { new Guid("7d623d83-4aa1-4a42-bdb7-913b66765ffe"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Contém: Mochila, Saco de Dormir, 2 frascos de Óleo, 10 dias de Rações, Corda, Isqueiro, 10 Tochas e Cantil.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pacote de Explorador", 22.68f },
                    { new Guid("90d071bf-cc53-457a-8dd1-47abcb362d1f"), 1m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "O Óleo vem em frascos de 0,47 litros. Como ação de Utilizar, você pode derramar Óleo em torno de si mesmo em um raio de 1,5 m, ou arremessá-lo a até 6 m. O Óleo derramado queima por 2 rodadas se incendiado.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Óleo", 0.45f },
                    { new Guid("9401e2cc-2ebd-41c8-8bd5-80e99c339ce4"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Mochila comporta até 13,5 kg dentro de 0,03 m³. Também pode servir como alforje.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Mochila", 2.27f },
                    { new Guid("959ade7e-9bc3-425f-9cbe-669be3becb08"), 2m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "Usando Tinta, uma Pena é usada para escrever ou desenhar.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pena", 0f },
                    { new Guid("980b4369-1539-4b9b-8364-7a9984c57212"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Barril comporta até 150 litros de líquido ou até 0,11 m³ de materiais secos.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Barril", 31.75f },
                    { new Guid("9cce6dcd-f415-4bd4-bb08-bc8b074c1895"), 39m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Contém: Baú, Roupas Finas, Tinta, 5 Penas, Lamparina, 2 Estojos de Mapa ou Pergaminho, 4 frascos de Óleo, 5 folhas de Papel, 5 folhas de Pergaminho, Perfume e Isqueiro.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pacote de Diplomata", 17.69f },
                    { new Guid("9d534f67-87fa-40b9-a239-192e395f8f6c"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Como ação de Utilizar, você pode lançar um Gancho de Escalar para ancorar uma corda em uma superfície a até 15 m.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Gancho de Escalar", 1.81f },
                    { new Guid("a746bd69-ce73-47b0-9712-8c098adc0115"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Este kit contém ataduras, unguentos e talas. Como ação de Utilizar, você pode gastar um uso do kit para estabilizar uma criatura com 0 PV sem precisar fazer um teste de Sabedoria (Medicina). O kit tem 10 usos.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Kit de Cura", 1.36f },
                    { new Guid("aa91d145-f3b4-4905-9a33-e879ac190e81"), 5m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "Enquanto envolto em uma Manta, você tem Vantagem em testes de resistência contra frio extremo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Manta", 1.36f },
                    { new Guid("ac4048a0-432f-4f2b-b569-be64fcd6d642"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Aljava comporta até 20 Flechas.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Aljava", 0.45f },
                    { new Guid("ad288962-29f1-4c03-b343-a6842c964586"), 2m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "O Papel de alta qualidade é adequado para escrever e desenhar.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Papel", 0f },
                    { new Guid("b05e86d2-1cbb-4e4a-8b94-39d785809ea4"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Tenda acomoda até duas criaturas Pequenas ou Médias.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Tenda", 9.07f },
                    { new Guid("b2270829-7fa5-4716-b4fe-6a5518acb554"), 25m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Inclui biqueiras, luvas, pitons e arnês. Como ação de Utilizar, você pode se ancorar; ao fazê-lo, não pode cair mais de 7,5 m do ponto de ancoragem e não pode se mover mais de 7,5 m sem desfazer a ancoragem como Ação Bônus.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Kit de Escalada", 5.44f },
                    { new Guid("b6b61030-70bf-4a4e-bcbb-c3828471050f"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Roldana e Polia permite içar até quatro vezes o peso que você normalmente consegue levantar.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Roldana e Polia", 2.27f },
                    { new Guid("b6d19a57-d174-42ef-b2cf-5cc074dba214"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Espelho de aço portátil é útil para cosméticos pessoais, mas também para espiar por cantos e refletir luz como sinal.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Espelho", 0.23f },
                    { new Guid("bf3e999a-4325-4242-9cda-6eae490117f4"), 25m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Ao realizar a ação de Ataque, você pode substituir um de seus ataques por arremessar um frasco de Ácido. Alvo: uma criatura ou objeto visível a até 6 m. O alvo deve ser bem-sucedido em um teste de resistência de Destreza (CD 8 + modificador de Destreza + bônus de proficiência) ou sofre 2d6 de dano de Ácido.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Ácido", 0.45f },
                    { new Guid("c090334f-a5d4-416f-83f2-4c2d82835003"), 1m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "Um Saco comporta até 13,5 kg dentro de 0,03 m³.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Saco", 0.23f },
                    { new Guid("cb25d3ac-08e1-47af-9c00-659f1746a640"), 5m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "Uma Vara tem 3 m de comprimento.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Vara", 3.63f },
                    { new Guid("ce9eca49-0a8c-4657-be28-9ae769caf2bf"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Ao realizar a ação de Ataque, você pode substituir um de seus ataques por arremessar uma Rede. Alvo: uma criatura visível a até 4,5 m. A criatura deve ser bem-sucedida em um teste de resistência de Força (CD 10) ou ficará Restrita até ser liberada.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Rede", 1.36f },
                    { new Guid("d0db670e-a132-447e-90d6-38f5487c8c55"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Como ação de Utilizar, você pode usar Algemas para prender uma criatura Pequena ou Média relutante a até 1,5 m com condição Agarrada, Incapacitada ou Restrita, se for bem-sucedido em um teste de Destreza (CD 13). Escapar requer um teste de Destreza bem-sucedido (CD 20).", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Algemas", 0.45f },
                    { new Guid("d6694382-5c64-49f2-a085-571c3339ce6e"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Estojo de Mapa ou Pergaminho comporta até 10 folhas de papel ou 5 folhas de pergaminho.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Estojo de Mapa ou Pergaminho", 0.45f },
                    { new Guid("dbef2245-dc28-4d59-bc9d-211bfa6d7c82"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Garrafa de Vidro comporta até 0,71 litros.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Garrafa de Vidro", 0.9f },
                    { new Guid("dbfb51ac-bcb3-4219-af63-66d8f3482bea"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Lanterna Encoberta queima Óleo como combustível emitindo Luz Plena em um raio de 9 m e Luz Fraca por mais 9 m. Como Ação Bônus, você pode baixar o capuz, reduzindo a luz a Luz Fraca em um raio de 1,5 m.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Lanterna Encoberta", 1.36f },
                    { new Guid("dbfe313c-8277-4048-aae3-8248d556c9f1"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Uma Lanterna de Holofote queima Óleo como combustível emitindo Luz Plena em um Cone de 18 m e Luz Fraca por mais 18 m.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Lanterna de Holofote", 2.27f },
                    { new Guid("de3b6636-b23c-48dd-9b1c-daf38e4d48ff"), 50m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Como ação de Utilizar, você pode beber esta poção ou administrá-la a outra criatura. A criatura recupera 2d4 + 2 PV.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Poção de Cura", 0.23f },
                    { new Guid("e3f4fdda-99df-49cb-afe0-b3828e43c620"), 1m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "Por 1 hora, uma Vela acesa emite Luz Plena em um raio de 1,5 m e Luz Fraca por mais 1,5 m.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Vela", 0f },
                    { new Guid("e3fc7ad6-5390-4b2d-95c7-11d45c5be1ba"), 50m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Um Pergaminho de Magia contém as palavras de uma magia de nível 1. Se a magia estiver na lista de magias da sua classe, você pode ler o pergaminho e conjurá-la. O CD de resistência é 13 e o bônus de ataque é +5. O pergaminho se desintegra quando a conjuração é completada.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pergaminho de Magia (Nível 1)", 0f },
                    { new Guid("e5f28ca0-69e3-443d-93e0-0115c920db4f"), 25m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Ao realizar a ação de Ataque, você pode substituir um de seus ataques por arremessar um frasco de Água Benta. Alvo: uma criatura visível a até 6 m. O alvo deve ser bem-sucedido em um teste de resistência de Destreza (CD 8 + modificador de Destreza + bônus de proficiência) ou sofre 2d6 de dano Radiante se for um Morto-Vivo ou Demônio.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Água Benta", 0.45f },
                    { new Guid("ed975551-ccbb-4023-b78e-a74879d968d8"), 5m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), "Um Balde comporta até 0,014 m³ de conteúdo.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Balde", 0.9f },
                    { new Guid("ee4bfd57-487e-4fbf-b5c5-c742ef945366"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Enquanto veste uma Fantasia, você tem Vantagem em qualquer teste de habilidade para se passar pela pessoa ou tipo de pessoa que ela representa.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Fantasia", 1.81f },
                    { new Guid("f9c94385-8eeb-4793-9508-8d467f7076a0"), 5m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), "Uma Bolsa comporta até 3 kg dentro de 0,001 m³.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Bolsa", 0.23f },
                    { new Guid("fedaf3fc-b655-483c-9809-6d05874e5c2b"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), "Trabalhando por 1 hora, você pode usar uma Pá para cavar um buraco de 1,5 m de cada lado em solo ou material similar.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pá", 2.27f }
                });

            migrationBuilder.InsertData(
                table: "shield_armor",
                columns: new[] { "id", "armor_category_id", "armor_class_bonus", "cost", "cost_currency_type_id", "disadvantage_on_stealth", "game_system_version_id", "name", "required_ability_score_id", "required_ability_score_minimum", "weight" },
                values: new object[] { new Guid("22d0681b-a63f-472b-98e5-7fe250440838"), new Guid("f96ce39f-902b-431f-bec5-2de186cdead8"), (byte)2, 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), false, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Escudo", null, (byte)0, 6f });

            migrationBuilder.InsertData(
                table: "skill",
                columns: new[] { "id", "base_ability_score_id", "description", "game_system_version_id", "name" },
                values: new object[,]
                {
                    { new Guid("0cc70771-7fd5-43f6-9c09-eca910d000bc"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), "Acrobacia representa a habilidade de se manter em pé em situações difíceis ou de realizar manobras acrobáticas.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Acrobacia" },
                    { new Guid("101b761a-f211-4896-9cfd-7df2211967bf"), new Guid("6ba5e150-fe51-46d4-af2c-1d101108eb7f"), "Arcanismo representa o conhecimento sobre magias, itens mágicos e os planos de existência.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Arcanismo" },
                    { new Guid("110f9b12-1bd0-4186-bb5d-8719d9b1876e"), new Guid("6ba5e150-fe51-46d4-af2c-1d101108eb7f"), "História representa o conhecimento sobre eventos históricos, personalidades, nações e culturas.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "História" },
                    { new Guid("288ac772-28b2-4135-ab85-880b2261aa04"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), "Atletismo representa a habilidade de saltar distâncias maiores, se manter à tona em águas agitadas ou quebrar objetos.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Atletismo" },
                    { new Guid("40570152-c43f-408a-a144-d6bacaa044de"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), "Furtividade representa a habilidade de passar despercebido movendo-se silenciosamente e se escondendo atrás de objetos.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Furtividade" },
                    { new Guid("45bc60a1-0a7a-412e-867a-8b9130ea8097"), new Guid("776e8837-3b8e-4533-86b3-ca72f50a15fe"), "Medicina representa a habilidade de diagnosticar uma doença ou determinar o que matou um ser recém-falecido.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Medicina" },
                    { new Guid("47d771d4-b4b3-4331-980e-7bd83a8a4f9d"), new Guid("151e6233-d307-47c5-ab78-fff32cd510a0"), "Atuação representa a habilidade de atuar, contar histórias, fazer música ou dançar.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Atuação" },
                    { new Guid("4c233f0a-1dc7-488b-a1a7-62aaf4478036"), new Guid("776e8837-3b8e-4533-86b3-ca72f50a15fe"), "Intuição representa a habilidade de discernir o estado de espírito e as intenções de uma pessoa.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Intuição" },
                    { new Guid("52ee91f8-2222-4033-bcc6-f95eacdd6a03"), new Guid("776e8837-3b8e-4533-86b3-ca72f50a15fe"), "Percepção representa a habilidade de notar algo difícil de detectar usando uma combinação dos sentidos.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Percepção" },
                    { new Guid("5803f8dd-5319-46c9-9aa2-bf1bc0c8fffa"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), "Prestidigitação representa a habilidade de bater carteiras, ocultar objetos pequenos ou realizar truques de mão.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Prestidigitação" },
                    { new Guid("5b22e220-bb6e-4fab-bb78-f38d43611cf4"), new Guid("151e6233-d307-47c5-ab78-fff32cd510a0"), "Enganação representa a habilidade de contar uma mentira convincente ou usar um disfarce de forma persuasiva.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Enganação" },
                    { new Guid("6b9a1439-7afb-4af3-bb2e-033b120b3d5c"), new Guid("6ba5e150-fe51-46d4-af2c-1d101108eb7f"), "Natureza representa o conhecimento sobre terrenos, plantas, animais e condições climáticas.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Natureza" },
                    { new Guid("751cbeb5-8237-4832-8261-93312e53a1c7"), new Guid("151e6233-d307-47c5-ab78-fff32cd510a0"), "Intimidação representa a habilidade de impressionar ou ameaçar alguém para que faça o que se deseja.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Intimidação" },
                    { new Guid("8ea3af82-0572-410e-95cb-6a92f58e4249"), new Guid("6ba5e150-fe51-46d4-af2c-1d101108eb7f"), "Investigação representa a habilidade de encontrar informações obscuras em livros ou deduzir como algo funciona.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Investigação" },
                    { new Guid("b2cfe13e-7fec-4388-86e1-5daa107294c0"), new Guid("151e6233-d307-47c5-ab78-fff32cd510a0"), "Persuasão representa a habilidade de convencer alguém de algo de forma honesta e graciosa.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Persuasão" },
                    { new Guid("be7457f5-62e7-4621-93e6-8d4e08fa08ab"), new Guid("6ba5e150-fe51-46d4-af2c-1d101108eb7f"), "Religião representa o conhecimento sobre deuses, rituais religiosos e símbolos sagrados.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Religião" },
                    { new Guid("f1914942-748c-4374-8d2a-154bc20a4572"), new Guid("776e8837-3b8e-4533-86b3-ca72f50a15fe"), "Adestrar Animais representa a habilidade de acalmar ou treinar um animal, ou fazê-lo se comportar de determinada maneira.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Adestrar Animais" },
                    { new Guid("fd499185-870a-4c89-bfbe-ec2108bbca88"), new Guid("776e8837-3b8e-4533-86b3-ca72f50a15fe"), "Sobrevivência representa a habilidade de seguir rastros, forragear, encontrar trilhas ou evitar perigos naturais.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Sobrevivência" }
                });

            migrationBuilder.InsertData(
                table: "weapon",
                columns: new[] { "id", "base_ability_score_id", "cost", "cost_currency_type_id", "game_system_version_id", "name", "weapon_category_id", "weapon_mastery_property_id", "weapon_type_id", "weight" },
                values: new object[,]
                {
                    { new Guid("0cf164af-5e62-4ce0-88c4-65504fd18fd4"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 15m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Espada Longa", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("b48306f5-a709-4ac4-9eec-f043ed563347"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 1.35f },
                    { new Guid("0f5ad2aa-e802-4f05-ba50-7f580b435da1"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 5m, new Guid("4b020d96-eb36-4459-8dc4-999c59b3839d"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Dardo", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("008399a1-f923-4c70-a37b-42a4ac2d60bf"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 0.11f },
                    { new Guid("213126a2-2af0-4f57-bcc3-2f68f05fc66e"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 25m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Cimitarra", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("38817c5e-a384-4f8f-bc13-f088b9370769"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 1.35f },
                    { new Guid("24f9b30f-81fc-4af0-981a-2f49d73883c0"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pique", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("ceb10c65-cc41-4605-84b0-6b123f2cc825"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 8.1f },
                    { new Guid("290b3087-e4d0-4621-85d7-6d2e9fd1752b"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Lança", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("b48306f5-a709-4ac4-9eec-f043ed563347"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 1.35f },
                    { new Guid("2b6f3e81-8434-4c8e-9739-d2ace3739e1b"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 25m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Besta Leve", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("35d851a8-b212-49c9-b709-c41014c60e40"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 2.25f },
                    { new Guid("2f0ac66a-eb93-4554-a142-d11da9db305c"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 500m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Mosquete", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("35d851a8-b212-49c9-b709-c41014c60e40"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 4.5f },
                    { new Guid("376860ac-2af3-479a-a5ba-e27b0199724e"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 75m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Besta de Mão", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("008399a1-f923-4c70-a37b-42a4ac2d60bf"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 1.35f },
                    { new Guid("41ecdf3e-8c07-45ef-8715-99ba2852c524"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Machadinha", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("008399a1-f923-4c70-a37b-42a4ac2d60bf"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f },
                    { new Guid("5048b4f1-68c4-4ada-99f3-4c34ff45301e"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Maça", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("b48306f5-a709-4ac4-9eec-f043ed563347"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 1.8f },
                    { new Guid("63aec956-4622-477b-b4bb-5e9e8353f383"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 50m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Arco Longo", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("35d851a8-b212-49c9-b709-c41014c60e40"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 0.9f },
                    { new Guid("65542377-ce4e-4db3-b941-8bc562774c16"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Tridente", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("f119f390-5d70-49ba-b520-289d9bbf272e"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 1.8f },
                    { new Guid("71ee7150-c84c-4bd8-a4c0-567602c75426"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Adaga", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("38817c5e-a384-4f8f-bc13-f088b9370769"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.45f },
                    { new Guid("77cdec20-43e3-4b5c-aa6d-680ad82764e6"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 30m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Machado Grande", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("f80143e5-99ec-48f2-acec-6aeb47ee2069"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 3.15f },
                    { new Guid("7d6c64e6-49d1-4141-b51c-09f682b92d89"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 20m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Alabarda", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("f80143e5-99ec-48f2-acec-6aeb47ee2069"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 2.7f },
                    { new Guid("7da0d639-bb37-40db-9815-39f9569c9c50"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 20m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Glaive", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("4420b7a1-2fdd-47f0-b32a-f35d13e9974d"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 2.7f },
                    { new Guid("7fc67548-156d-4bb4-9dbe-4127cac70bc8"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 5m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Dardo de Arremesso", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("35d851a8-b212-49c9-b709-c41014c60e40"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f },
                    { new Guid("8125e687-8f11-4538-946a-764f3c3e18fd"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Lança de Cavalaria", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("f119f390-5d70-49ba-b520-289d9bbf272e"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 2.7f },
                    { new Guid("8319c578-3c02-463a-a0ba-a7d77e573bb7"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 1m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Foice", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("38817c5e-a384-4f8f-bc13-f088b9370769"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f },
                    { new Guid("832517dc-1a3b-4cb6-960c-64f8d540e85b"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 15m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Estrela da Manhã", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("b48306f5-a709-4ac4-9eec-f043ed563347"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 1.8f },
                    { new Guid("88569254-ead6-4c23-8f80-e3fa3702a918"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 25m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Arco Curto", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("008399a1-f923-4c70-a37b-42a4ac2d60bf"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 0.9f },
                    { new Guid("88714ade-f7dd-4190-ad21-9af14eae3be9"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Mangual", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("b48306f5-a709-4ac4-9eec-f043ed563347"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f },
                    { new Guid("8b75871f-084f-4b94-9e96-4c06b836059d"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Machado de Batalha", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("f119f390-5d70-49ba-b520-289d9bbf272e"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 1.8f },
                    { new Guid("8d1b8c4f-2bdb-4f79-8958-b99e65bb0571"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 2m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Bastão", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("f119f390-5d70-49ba-b520-289d9bbf272e"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 1.8f },
                    { new Guid("90dbad53-5677-481d-945e-5c45b2e4f0bf"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 250m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Pistola", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("008399a1-f923-4c70-a37b-42a4ac2d60bf"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 1.35f },
                    { new Guid("96bca94f-5c6b-4196-8677-109f8068e080"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 1m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Funda", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("35d851a8-b212-49c9-b709-c41014c60e40"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 0f },
                    { new Guid("b6c6c808-bb04-46e8-98cd-8bf926bc94b9"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 2m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Clava Grande", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("ceb10c65-cc41-4605-84b0-6b123f2cc825"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 4.5f },
                    { new Guid("bab0ed83-da37-4cab-8f1a-59a9d53a57c2"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Picareta de Guerra", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("b48306f5-a709-4ac4-9eec-f043ed563347"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f },
                    { new Guid("c8050a1d-dd3c-4df7-80c1-6f4e1678006b"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Zarabatana", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("008399a1-f923-4c70-a37b-42a4ac2d60bf"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 0.45f },
                    { new Guid("c812d2f0-dbc5-49c7-9f12-7b3b7102dea5"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 50m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Espadão", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("4420b7a1-2fdd-47f0-b32a-f35d13e9974d"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 2.7f },
                    { new Guid("d5972e5a-dddf-4d55-84a3-6a7e7802b744"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 1m, new Guid("9516a502-d6b7-401f-9b00-08893d977bc3"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Clava", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("35d851a8-b212-49c9-b709-c41014c60e40"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f },
                    { new Guid("d7b21653-6f4b-4d88-9023-5a028199c249"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Espada Curta", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("008399a1-f923-4c70-a37b-42a4ac2d60bf"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f },
                    { new Guid("dc372852-8c1b-4cb5-beab-3dab4bcda853"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 25m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Rapieira", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("008399a1-f923-4c70-a37b-42a4ac2d60bf"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f },
                    { new Guid("ddb677b4-90e7-4268-aa81-bb6be8a1b476"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Chicote", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("35d851a8-b212-49c9-b709-c41014c60e40"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f },
                    { new Guid("ec068572-ce9d-4013-941d-242e90d658da"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 15m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Martelo de Guerra", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("ceb10c65-cc41-4605-84b0-6b123f2cc825"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 2.25f },
                    { new Guid("ee4f8ed7-f38b-415a-86c1-2162170677e7"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Malho", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("f119f390-5d70-49ba-b520-289d9bbf272e"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 4.5f },
                    { new Guid("f1de791c-9264-493c-9536-68944caade5b"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), 50m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Besta Pesada", new Guid("b1e6191b-4b5c-40e6-90d1-e821bdd2301c"), new Guid("ceb10c65-cc41-4605-84b0-6b123f2cc825"), new Guid("4890eebf-8042-4d12-a944-bbd1f7800bf3"), 8.1f },
                    { new Guid("ff23e7af-2490-4fa5-a960-93cc8c9f5580"), new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), 2m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Martelo Leve", new Guid("fc9af856-f8f1-4f35-baeb-12265f4e2e5c"), new Guid("38817c5e-a384-4f8f-bc13-f088b9370769"), new Guid("172572cd-3126-4e11-843f-fcba258fd0a6"), 0.9f }
                });

            migrationBuilder.InsertData(
                table: "weapon_property",
                columns: new[] { "id", "alternative_ability_score_id", "description", "game_system_version_id", "name" },
                values: new object[] { new Guid("ed3b4dbf-59e2-472d-8672-4162700f339d"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), "Ao atacar com uma arma de Acuidade, use sua escolha entre o modificador de Força ou Destreza para as jogadas de ataque e dano. Você deve usar o mesmo modificador para ambas.", new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), "Acuidade" });

            migrationBuilder.InsertData(
                table: "wearable_armor",
                columns: new[] { "id", "applies_ability_modifier", "armor_category_id", "armor_class_ability_score_modifier_id", "base_armor_class", "cost", "cost_currency_type_id", "disadvantage_on_stealth", "game_system_version_id", "max_ability_modifier", "name", "required_ability_score_id", "required_ability_score_minimum", "weight" },
                values: new object[,]
                {
                    { new Guid("02fdf497-6274-4f7e-bb08-d7a8760b3927"), true, new Guid("f9cae1d9-32a1-4a80-abce-995319ad42ef"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), (byte)14, 50m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), true, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)2, "Armadura de Escamas", null, (byte)0, 45f },
                    { new Guid("05abd86e-29c5-428c-b5e7-55b541166df1"), true, new Guid("f9cae1d9-32a1-4a80-abce-995319ad42ef"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), (byte)12, 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), false, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)2, "Armadura de Peles", null, (byte)0, 12f },
                    { new Guid("28cdaed7-6541-4828-aca9-e8a01f65c5af"), false, new Guid("626c8290-d046-462c-ab83-19c84917ab06"), null, (byte)18, 1500m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), true, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)0, "Armadura de Placas", new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), (byte)0, 65f },
                    { new Guid("35572451-b088-4c66-be5a-70ad0598166e"), false, new Guid("f96ce39f-902b-431f-bec5-2de186cdead8"), null, (byte)2, 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), false, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)0, "Escudo", null, (byte)0, 6f },
                    { new Guid("3a8f1932-f8fd-4f30-b867-a13d5f596763"), true, new Guid("6125d19e-20f6-4333-8b5a-4408021150bd"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), (byte)11, 5m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), true, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)0, "Armadura Acolchoada", null, (byte)0, 8f },
                    { new Guid("43451c8a-0373-4956-b006-679497a1b54f"), true, new Guid("f9cae1d9-32a1-4a80-abce-995319ad42ef"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), (byte)13, 50m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), false, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)2, "Camisola de Malha", null, (byte)0, 20f },
                    { new Guid("64d72fe1-cb9d-479a-b2a3-c56cf43bed6c"), false, new Guid("626c8290-d046-462c-ab83-19c84917ab06"), null, (byte)14, 30m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), true, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)0, "Armadura de Anéis", null, (byte)0, 40f },
                    { new Guid("79a9d563-f8ad-43b6-b9bd-eeb99fa56d60"), true, new Guid("6125d19e-20f6-4333-8b5a-4408021150bd"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), (byte)12, 45m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), false, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)0, "Armadura de Couro Cravejado", null, (byte)0, 13f },
                    { new Guid("7a346e09-efd4-4c9e-aad8-a5155d067250"), true, new Guid("6125d19e-20f6-4333-8b5a-4408021150bd"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), (byte)11, 10m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), false, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)0, "Armadura de Couro", null, (byte)0, 10f },
                    { new Guid("828548da-cbcb-454c-be0b-3df8ee0b10ba"), true, new Guid("f9cae1d9-32a1-4a80-abce-995319ad42ef"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), (byte)14, 400m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), false, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)2, "Peitoral", null, (byte)0, 20f },
                    { new Guid("92394327-b45a-4a9c-8d9a-df1bbcaf90f3"), true, new Guid("f9cae1d9-32a1-4a80-abce-995319ad42ef"), new Guid("ba3a731d-4756-4682-b589-e6ac61b9c640"), (byte)15, 750m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), true, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)2, "Meia Armadura de Placas", null, (byte)0, 40f },
                    { new Guid("cedb0ae8-6696-4bad-9fbc-ab98f6f21abb"), false, new Guid("626c8290-d046-462c-ab83-19c84917ab06"), null, (byte)16, 75m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), true, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)0, "Cota de Malha", new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), (byte)0, 55f },
                    { new Guid("f591fa07-e02f-40b3-8f09-3dc8c334b3a4"), false, new Guid("626c8290-d046-462c-ab83-19c84917ab06"), null, (byte)17, 200m, new Guid("61e2a4f3-6f6e-4277-8e3c-5e75accfb17c"), true, new Guid("b7486820-c2bf-4e28-ade7-78e08e069c6b"), (byte)0, "Armadura de Talas", new Guid("bcff0698-0e29-4829-a463-d8786b0c376a"), (byte)0, 60f }
                });

            migrationBuilder.InsertData(
                table: "weapon_damage",
                columns: new[] { "damage_type_id", "dice_type_id", "weapon_id", "dice_quantity" },
                values: new object[,]
                {
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("0cf164af-5e62-4ce0-88c4-65504fd18fd4"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("0cf164af-5e62-4ce0-88c4-65504fd18fd4"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("049b9edf-f128-4286-a327-d0124d790775"), new Guid("0f5ad2aa-e802-4f05-ba50-7f580b435da1"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("213126a2-2af0-4f57-bcc3-2f68f05fc66e"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("24f9b30f-81fc-4af0-981a-2f49d73883c0"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("290b3087-e4d0-4621-85d7-6d2e9fd1752b"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("290b3087-e4d0-4621-85d7-6d2e9fd1752b"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("2b6f3e81-8434-4c8e-9739-d2ace3739e1b"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("18cedc29-1808-4739-982d-bc8a74613d6c"), new Guid("2f0ac66a-eb93-4554-a142-d11da9db305c"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("376860ac-2af3-479a-a5ba-e27b0199724e"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("41ecdf3e-8c07-45ef-8715-99ba2852c524"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("5048b4f1-68c4-4ada-99f3-4c34ff45301e"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("63aec956-4622-477b-b4bb-5e9e8353f383"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("65542377-ce4e-4db3-b941-8bc562774c16"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("65542377-ce4e-4db3-b941-8bc562774c16"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("049b9edf-f128-4286-a327-d0124d790775"), new Guid("71ee7150-c84c-4bd8-a4c0-567602c75426"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("18cedc29-1808-4739-982d-bc8a74613d6c"), new Guid("77cdec20-43e3-4b5c-aa6d-680ad82764e6"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("7d6c64e6-49d1-4141-b51c-09f682b92d89"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("7da0d639-bb37-40db-9815-39f9569c9c50"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("7fc67548-156d-4bb4-9dbe-4127cac70bc8"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("8125e687-8f11-4538-946a-764f3c3e18fd"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("049b9edf-f128-4286-a327-d0124d790775"), new Guid("8319c578-3c02-463a-a0ba-a7d77e573bb7"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("832517dc-1a3b-4cb6-960c-64f8d540e85b"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("88569254-ead6-4c23-8f80-e3fa3702a918"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("88714ade-f7dd-4190-ad21-9af14eae3be9"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("8b75871f-084f-4b94-9e96-4c06b836059d"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("8b75871f-084f-4b94-9e96-4c06b836059d"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("8d1b8c4f-2bdb-4f79-8958-b99e65bb0571"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("8d1b8c4f-2bdb-4f79-8958-b99e65bb0571"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("90dbad53-5677-481d-945e-5c45b2e4f0bf"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("049b9edf-f128-4286-a327-d0124d790775"), new Guid("96bca94f-5c6b-4196-8677-109f8068e080"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("b6c6c808-bb04-46e8-98cd-8bf926bc94b9"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("bab0ed83-da37-4cab-8f1a-59a9d53a57c2"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("bab0ed83-da37-4cab-8f1a-59a9d53a57c2"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("049b9edf-f128-4286-a327-d0124d790775"), new Guid("c8050a1d-dd3c-4df7-80c1-6f4e1678006b"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("c812d2f0-dbc5-49c7-9f12-7b3b7102dea5"), (byte)2 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("049b9edf-f128-4286-a327-d0124d790775"), new Guid("d5972e5a-dddf-4d55-84a3-6a7e7802b744"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("d7b21653-6f4b-4d88-9023-5a028199c249"), (byte)1 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("dc372852-8c1b-4cb5-beab-3dab4bcda853"), (byte)1 },
                    { new Guid("d2a4b368-b8ca-4c63-ba30-e0637a8423e6"), new Guid("049b9edf-f128-4286-a327-d0124d790775"), new Guid("ddb677b4-90e7-4268-aa81-bb6be8a1b476"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("823cdd08-a5c3-47dd-ae41-919de36355a9"), new Guid("ec068572-ce9d-4013-941d-242e90d658da"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("ec068572-ce9d-4013-941d-242e90d658da"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("9df455ab-17ee-4b65-b4a9-da07cc1a9a2b"), new Guid("ee4f8ed7-f38b-415a-86c1-2162170677e7"), (byte)2 },
                    { new Guid("019a1e8b-75e2-414f-bc3e-3fe99a3baf23"), new Guid("d7d6997b-9cc6-4cfb-93cf-ad24f5e66f5f"), new Guid("f1de791c-9264-493c-9536-68944caade5b"), (byte)1 },
                    { new Guid("8fcb68f4-c340-462a-8797-7c2fbbe97ed1"), new Guid("049b9edf-f128-4286-a327-d0124d790775"), new Guid("ff23e7af-2490-4fa5-a960-93cc8c9f5580"), (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "weapon_property_attribute",
                columns: new[] { "weapon_id", "weapon_property_id", "ammunition_type_id", "long_range", "normal_range", "remarks" },
                values: new object[,]
                {
                    { new Guid("0cf164af-5e62-4ce0-88c4-65504fd18fd4"), new Guid("4b93f9df-b2a7-4dd9-a432-ade50984b03a"), null, null, null, null },
                    { new Guid("0f5ad2aa-e802-4f05-ba50-7f580b435da1"), new Guid("ed3b4dbf-59e2-472d-8672-4162700f339d"), null, null, null, null },
                    { new Guid("0f5ad2aa-e802-4f05-ba50-7f580b435da1"), new Guid("fe6d71c8-a79a-46c8-a9dd-8646bf06aae7"), null, 18f, 6f, null },
                    { new Guid("213126a2-2af0-4f57-bcc3-2f68f05fc66e"), new Guid("12036b7e-0da3-446a-a955-f7cc1d87198e"), null, null, null, null },
                    { new Guid("213126a2-2af0-4f57-bcc3-2f68f05fc66e"), new Guid("ed3b4dbf-59e2-472d-8672-4162700f339d"), null, null, null, null },
                    { new Guid("24f9b30f-81fc-4af0-981a-2f49d73883c0"), new Guid("3cf4244f-559c-4c6a-b1b1-531dce23d615"), null, null, null, null },
                    { new Guid("24f9b30f-81fc-4af0-981a-2f49d73883c0"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("24f9b30f-81fc-4af0-981a-2f49d73883c0"), new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, null, null, null },
                    { new Guid("290b3087-e4d0-4621-85d7-6d2e9fd1752b"), new Guid("4b93f9df-b2a7-4dd9-a432-ade50984b03a"), null, null, null, null },
                    { new Guid("290b3087-e4d0-4621-85d7-6d2e9fd1752b"), new Guid("fe6d71c8-a79a-46c8-a9dd-8646bf06aae7"), null, 18f, 6f, null },
                    { new Guid("2b6f3e81-8434-4c8e-9739-d2ace3739e1b"), new Guid("399ccecc-0e45-440e-a4c0-4056be0b5bf4"), null, null, null, null },
                    { new Guid("2b6f3e81-8434-4c8e-9739-d2ace3739e1b"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("2b6f3e81-8434-4c8e-9739-d2ace3739e1b"), new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, 96f, 24f, null },
                    { new Guid("2f0ac66a-eb93-4554-a142-d11da9db305c"), new Guid("399ccecc-0e45-440e-a4c0-4056be0b5bf4"), null, null, null, null },
                    { new Guid("2f0ac66a-eb93-4554-a142-d11da9db305c"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("2f0ac66a-eb93-4554-a142-d11da9db305c"), new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, 36f, 12f, null },
                    { new Guid("376860ac-2af3-479a-a5ba-e27b0199724e"), new Guid("12036b7e-0da3-446a-a955-f7cc1d87198e"), null, null, null, null },
                    { new Guid("376860ac-2af3-479a-a5ba-e27b0199724e"), new Guid("399ccecc-0e45-440e-a4c0-4056be0b5bf4"), null, null, null, null },
                    { new Guid("376860ac-2af3-479a-a5ba-e27b0199724e"), new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, 36f, 9f, null },
                    { new Guid("41ecdf3e-8c07-45ef-8715-99ba2852c524"), new Guid("12036b7e-0da3-446a-a955-f7cc1d87198e"), null, null, null, null },
                    { new Guid("41ecdf3e-8c07-45ef-8715-99ba2852c524"), new Guid("fe6d71c8-a79a-46c8-a9dd-8646bf06aae7"), null, 18f, 6f, null },
                    { new Guid("63aec956-4622-477b-b4bb-5e9e8353f383"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("63aec956-4622-477b-b4bb-5e9e8353f383"), new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, 180f, 45f, null },
                    { new Guid("63aec956-4622-477b-b4bb-5e9e8353f383"), new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, null, null, null },
                    { new Guid("65542377-ce4e-4db3-b941-8bc562774c16"), new Guid("4b93f9df-b2a7-4dd9-a432-ade50984b03a"), null, null, null, null },
                    { new Guid("65542377-ce4e-4db3-b941-8bc562774c16"), new Guid("fe6d71c8-a79a-46c8-a9dd-8646bf06aae7"), null, 18f, 6f, null },
                    { new Guid("71ee7150-c84c-4bd8-a4c0-567602c75426"), new Guid("12036b7e-0da3-446a-a955-f7cc1d87198e"), null, null, null, null },
                    { new Guid("71ee7150-c84c-4bd8-a4c0-567602c75426"), new Guid("ed3b4dbf-59e2-472d-8672-4162700f339d"), null, null, null, null },
                    { new Guid("71ee7150-c84c-4bd8-a4c0-567602c75426"), new Guid("fe6d71c8-a79a-46c8-a9dd-8646bf06aae7"), null, 18f, 6f, null },
                    { new Guid("77cdec20-43e3-4b5c-aa6d-680ad82764e6"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("77cdec20-43e3-4b5c-aa6d-680ad82764e6"), new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, null, null, null },
                    { new Guid("7d6c64e6-49d1-4141-b51c-09f682b92d89"), new Guid("3cf4244f-559c-4c6a-b1b1-531dce23d615"), null, null, null, null },
                    { new Guid("7d6c64e6-49d1-4141-b51c-09f682b92d89"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("7d6c64e6-49d1-4141-b51c-09f682b92d89"), new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, null, null, null },
                    { new Guid("7da0d639-bb37-40db-9815-39f9569c9c50"), new Guid("3cf4244f-559c-4c6a-b1b1-531dce23d615"), null, null, null, null },
                    { new Guid("7da0d639-bb37-40db-9815-39f9569c9c50"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("7da0d639-bb37-40db-9815-39f9569c9c50"), new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, null, null, null },
                    { new Guid("7fc67548-156d-4bb4-9dbe-4127cac70bc8"), new Guid("fe6d71c8-a79a-46c8-a9dd-8646bf06aae7"), null, 36f, 9f, null },
                    { new Guid("8125e687-8f11-4538-946a-764f3c3e18fd"), new Guid("3cf4244f-559c-4c6a-b1b1-531dce23d615"), null, null, null, null },
                    { new Guid("8125e687-8f11-4538-946a-764f3c3e18fd"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, "A menos que esteja montado" },
                    { new Guid("8125e687-8f11-4538-946a-764f3c3e18fd"), new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, null, null, null },
                    { new Guid("8319c578-3c02-463a-a0ba-a7d77e573bb7"), new Guid("12036b7e-0da3-446a-a955-f7cc1d87198e"), null, null, null, null },
                    { new Guid("88569254-ead6-4c23-8f80-e3fa3702a918"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("88569254-ead6-4c23-8f80-e3fa3702a918"), new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, 96f, 24f, null },
                    { new Guid("8b75871f-084f-4b94-9e96-4c06b836059d"), new Guid("4b93f9df-b2a7-4dd9-a432-ade50984b03a"), null, null, null, null },
                    { new Guid("8d1b8c4f-2bdb-4f79-8958-b99e65bb0571"), new Guid("4b93f9df-b2a7-4dd9-a432-ade50984b03a"), null, null, null, null },
                    { new Guid("90dbad53-5677-481d-945e-5c45b2e4f0bf"), new Guid("399ccecc-0e45-440e-a4c0-4056be0b5bf4"), null, null, null, null },
                    { new Guid("90dbad53-5677-481d-945e-5c45b2e4f0bf"), new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, 27f, 9f, null },
                    { new Guid("96bca94f-5c6b-4196-8677-109f8068e080"), new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, 36f, 9f, null },
                    { new Guid("b6c6c808-bb04-46e8-98cd-8bf926bc94b9"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("bab0ed83-da37-4cab-8f1a-59a9d53a57c2"), new Guid("4b93f9df-b2a7-4dd9-a432-ade50984b03a"), null, null, null, null },
                    { new Guid("c8050a1d-dd3c-4df7-80c1-6f4e1678006b"), new Guid("399ccecc-0e45-440e-a4c0-4056be0b5bf4"), null, null, null, null },
                    { new Guid("c8050a1d-dd3c-4df7-80c1-6f4e1678006b"), new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, 30f, 7.5f, null },
                    { new Guid("c812d2f0-dbc5-49c7-9f12-7b3b7102dea5"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("c812d2f0-dbc5-49c7-9f12-7b3b7102dea5"), new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, null, null, null },
                    { new Guid("d5972e5a-dddf-4d55-84a3-6a7e7802b744"), new Guid("12036b7e-0da3-446a-a955-f7cc1d87198e"), null, null, null, null },
                    { new Guid("d7b21653-6f4b-4d88-9023-5a028199c249"), new Guid("12036b7e-0da3-446a-a955-f7cc1d87198e"), null, null, null, null },
                    { new Guid("d7b21653-6f4b-4d88-9023-5a028199c249"), new Guid("ed3b4dbf-59e2-472d-8672-4162700f339d"), null, null, null, null },
                    { new Guid("dc372852-8c1b-4cb5-beab-3dab4bcda853"), new Guid("ed3b4dbf-59e2-472d-8672-4162700f339d"), null, null, null, null },
                    { new Guid("ddb677b4-90e7-4268-aa81-bb6be8a1b476"), new Guid("3cf4244f-559c-4c6a-b1b1-531dce23d615"), null, null, null, null },
                    { new Guid("ddb677b4-90e7-4268-aa81-bb6be8a1b476"), new Guid("ed3b4dbf-59e2-472d-8672-4162700f339d"), null, null, null, null },
                    { new Guid("ec068572-ce9d-4013-941d-242e90d658da"), new Guid("4b93f9df-b2a7-4dd9-a432-ade50984b03a"), null, null, null, null },
                    { new Guid("ee4f8ed7-f38b-415a-86c1-2162170677e7"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("ee4f8ed7-f38b-415a-86c1-2162170677e7"), new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, null, null, null },
                    { new Guid("f1de791c-9264-493c-9536-68944caade5b"), new Guid("399ccecc-0e45-440e-a4c0-4056be0b5bf4"), null, null, null, null },
                    { new Guid("f1de791c-9264-493c-9536-68944caade5b"), new Guid("3e79de9f-c9cc-4645-923c-0fdd5a47ffa1"), null, null, null, null },
                    { new Guid("f1de791c-9264-493c-9536-68944caade5b"), new Guid("8d679879-00e2-47a2-9627-17d85179d50f"), null, 120f, 30f, null },
                    { new Guid("f1de791c-9264-493c-9536-68944caade5b"), new Guid("ee41b3ef-1b41-4b1c-a0f1-ef3a63cd622b"), null, null, null, null },
                    { new Guid("ff23e7af-2490-4fa5-a960-93cc8c9f5580"), new Guid("12036b7e-0da3-446a-a955-f7cc1d87198e"), null, null, null, null },
                    { new Guid("ff23e7af-2490-4fa5-a960-93cc8c9f5580"), new Guid("fe6d71c8-a79a-46c8-a9dd-8646bf06aae7"), null, 18f, 6f, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ability_score_game_system_version_id",
                table: "ability_score",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_alignment_game_system_version_id",
                table: "alignment",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_ammunition_type_cost_currency_type_id",
                table: "ammunition_type",
                column: "cost_currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_ammunition_type_game_system_version_id",
                table: "ammunition_type",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_armor_category_game_system_version_id",
                table: "armor_category",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_currency_conversion_rate_to_currency_type_id",
                table: "currency_conversion_rate",
                column: "to_currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_currency_type_game_system_version_id",
                table: "currency_type",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_damage_type_game_system_version_id",
                table: "damage_type",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_game_system_version_game_system_id",
                table: "game_system_version",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_gear_cost_currency_type_id",
                table: "gear",
                column: "cost_currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_gear_game_system_version_id",
                table: "gear",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_language_game_system_version_id",
                table: "language",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_level_game_system_version_id",
                table: "level",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_shield_armor_armor_category_id",
                table: "shield_armor",
                column: "armor_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_shield_armor_cost_currency_type_id",
                table: "shield_armor",
                column: "cost_currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_shield_armor_game_system_version_id",
                table: "shield_armor",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_shield_armor_required_ability_score_id",
                table: "shield_armor",
                column: "required_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_size_game_system_version_id",
                table: "size",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_skill_base_ability_score_id",
                table: "skill",
                column: "base_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_skill_game_system_version_id",
                table: "skill",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_tool_check_ability_score_id",
                table: "tool",
                column: "check_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_tool_cost_currency_type_id",
                table: "tool",
                column: "cost_currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_tool_game_system_version_id",
                table: "tool",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_tool_tool_category_id",
                table: "tool",
                column: "tool_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_tool_category_game_system_version_id",
                table: "tool_category",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_role_id",
                table: "user_role",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_base_ability_score_id",
                table: "weapon",
                column: "base_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_cost_currency_type_id",
                table: "weapon",
                column: "cost_currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_game_system_version_id",
                table: "weapon",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_weapon_category_id",
                table: "weapon",
                column: "weapon_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_weapon_mastery_property_id",
                table: "weapon",
                column: "weapon_mastery_property_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_weapon_type_id",
                table: "weapon",
                column: "weapon_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_category_game_system_version_id",
                table: "weapon_category",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_damage_damage_type_id",
                table: "weapon_damage",
                column: "damage_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_damage_dice_type_id",
                table: "weapon_damage",
                column: "dice_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_mastery_property_game_system_version_id",
                table: "weapon_mastery_property",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_property_alternative_ability_score_id",
                table: "weapon_property",
                column: "alternative_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_property_game_system_version_id",
                table: "weapon_property",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_property_attribute_ammunition_type_id",
                table: "weapon_property_attribute",
                column: "ammunition_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_property_attribute_weapon_property_id",
                table: "weapon_property_attribute",
                column: "weapon_property_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_type_game_system_version_id",
                table: "weapon_type",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_wearable_armor_armor_category_id",
                table: "wearable_armor",
                column: "armor_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_wearable_armor_armor_class_ability_score_modifier_id",
                table: "wearable_armor",
                column: "armor_class_ability_score_modifier_id");

            migrationBuilder.CreateIndex(
                name: "IX_wearable_armor_cost_currency_type_id",
                table: "wearable_armor",
                column: "cost_currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_wearable_armor_game_system_version_id",
                table: "wearable_armor",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_wearable_armor_required_ability_score_id",
                table: "wearable_armor",
                column: "required_ability_score_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alignment");

            migrationBuilder.DropTable(
                name: "currency_conversion_rate");

            migrationBuilder.DropTable(
                name: "gear");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "level");

            migrationBuilder.DropTable(
                name: "shield_armor");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "tool");

            migrationBuilder.DropTable(
                name: "user_role");

            migrationBuilder.DropTable(
                name: "weapon_damage");

            migrationBuilder.DropTable(
                name: "weapon_property_attribute");

            migrationBuilder.DropTable(
                name: "wearable_armor");

            migrationBuilder.DropTable(
                name: "tool_category");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "damage_type");

            migrationBuilder.DropTable(
                name: "dice_type");

            migrationBuilder.DropTable(
                name: "ammunition_type");

            migrationBuilder.DropTable(
                name: "weapon_property");

            migrationBuilder.DropTable(
                name: "weapon");

            migrationBuilder.DropTable(
                name: "armor_category");

            migrationBuilder.DropTable(
                name: "ability_score");

            migrationBuilder.DropTable(
                name: "currency_type");

            migrationBuilder.DropTable(
                name: "weapon_category");

            migrationBuilder.DropTable(
                name: "weapon_mastery_property");

            migrationBuilder.DropTable(
                name: "weapon_type");

            migrationBuilder.DropTable(
                name: "game_system_version");

            migrationBuilder.DropTable(
                name: "game_system");
        }
    }
}
