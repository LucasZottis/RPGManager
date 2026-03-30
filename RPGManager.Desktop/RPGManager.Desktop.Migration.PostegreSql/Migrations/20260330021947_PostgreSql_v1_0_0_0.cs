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
            migrationBuilder.EnsureSchema(
                name: "pk_ammunitiontype");

            migrationBuilder.EnsureSchema(
                name: "pk_armor");

            migrationBuilder.EnsureSchema(
                name: "pk_gear");

            migrationBuilder.EnsureSchema(
                name: "pk_item");

            migrationBuilder.EnsureSchema(
                name: "pk_shieldarmor");

            migrationBuilder.EnsureSchema(
                name: "pk_tool");

            migrationBuilder.EnsureSchema(
                name: "pk_wearablearmor");

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
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValue: new DateTime(2026, 3, 29, 23, 19, 46, 863, DateTimeKind.Local).AddTicks(2102))
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
                name: "tool_category",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tool_category", x => x.id);
                    table.ForeignKey(
                        name: "fk_tool_category_game_system_game_system_id",
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
                name: "background",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_background", x => x.id);
                    table.ForeignKey(
                        name: "fk_background_game_system_version_game_system_version_id",
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
                    is_base_currency = table.Column<bool>(type: "boolean", nullable: false),
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
                name: "feat_category",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_feat_category", x => x.id);
                    table.ForeignKey(
                        name: "fk_feat_category_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "feature",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_feature", x => x.id);
                    table.ForeignKey(
                        name: "fk_feature_game_system_version_game_system_version_id",
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
                name: "race",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    parent_race_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true),
                    speed = table.Column<float>(type: "real", nullable: false),
                    creature_type = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race", x => x.id);
                    table.ForeignKey(
                        name: "fk_race_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_race_race_parent_race_id",
                        column: x => x.parent_race_id,
                        principalTable: "race",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    min_height = table.Column<float>(type: "real", nullable: false),
                    max_height = table.Column<float>(type: "real", nullable: false),
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
                name: "class",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false),
                    primary_ability_score_id = table.Column<Guid>(type: "uuid", nullable: false),
                    hit_dice_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_ability_score_primary_ability_score_id",
                        column: x => x.primary_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_dice_type_hit_dice_type_id",
                        column: x => x.hit_dice_type_id,
                        principalTable: "dice_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_game_system_version_game_system_version_id",
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
                name: "background_ability_score_choice",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    background_id = table.Column<Guid>(type: "uuid", nullable: false),
                    allowed_choices = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_background_ability_score_choice", x => x.id);
                    table.ForeignKey(
                        name: "fk_background_ability_score_choice_background_background_id",
                        column: x => x.background_id,
                        principalTable: "background",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "background_equipment_option",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    background_id = table.Column<Guid>(type: "uuid", nullable: false),
                    option_order = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_background_equipment_option", x => x.id);
                    table.ForeignKey(
                        name: "fk_background_equipment_option_background_background_id",
                        column: x => x.background_id,
                        principalTable: "background",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "background_tool_proficiency_choice",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    background_id = table.Column<Guid>(type: "uuid", nullable: false),
                    allowed_choices = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_background_tool_proficiency_choice", x => x.id);
                    table.ForeignKey(
                        name: "fk_background_tool_proficiency_choice_background_background_id",
                        column: x => x.background_id,
                        principalTable: "background",
                        principalColumn: "id");
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
                name: "feat",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    feat_category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false),
                    is_repeatable = table.Column<bool>(type: "boolean", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_feat", x => x.id);
                    table.ForeignKey(
                        name: "fk_feat_feat_category_feat_category_id",
                        column: x => x.feat_category_id,
                        principalTable: "feat_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_feat_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_ability_score",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    race_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ability_score_id = table.Column<Guid>(type: "uuid", nullable: false),
                    increase = table.Column<int>(type: "integer", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_ability_score", x => x.id);
                    table.ForeignKey(
                        name: "fk_race_ability_score_ability_score_ability_score_id",
                        column: x => x.ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_race_ability_score_race_race_id",
                        column: x => x.race_id,
                        principalTable: "race",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_ancestry",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    race_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_ancestry", x => x.id);
                    table.ForeignKey(
                        name: "fk_race_ancestry_race_race_id",
                        column: x => x.race_id,
                        principalTable: "race",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_language",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    race_id = table.Column<Guid>(type: "uuid", nullable: false),
                    language_id = table.Column<Guid>(type: "uuid", nullable: true),
                    is_choice = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_language", x => x.id);
                    table.ForeignKey(
                        name: "fk_race_language_language_language_id",
                        column: x => x.language_id,
                        principalTable: "language",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_race_language_race_race_id",
                        column: x => x.race_id,
                        principalTable: "race",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_skill_proficiency_choice",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    race_id = table.Column<Guid>(type: "uuid", nullable: false),
                    allowed_choices = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_skill_proficiency_choice", x => x.id);
                    table.ForeignKey(
                        name: "fk_race_skill_proficiency_choice_race_race_id",
                        column: x => x.race_id,
                        principalTable: "race",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_trait",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    race_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false),
                    required_level = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_trait", x => x.id);
                    table.ForeignKey(
                        name: "fk_race_trait_race_race_id",
                        column: x => x.race_id,
                        principalTable: "race",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "spell",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    race_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_spell", x => x.id);
                    table.ForeignKey(
                        name: "fk_spell_race_race_id",
                        column: x => x.race_id,
                        principalTable: "race",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "race_size_option",
                columns: table => new
                {
                    race_id = table.Column<Guid>(type: "uuid", nullable: false),
                    size_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_size_option", x => new { x.race_id, x.size_id });
                    table.ForeignKey(
                        name: "fk_race_size_option_race_race_id",
                        column: x => x.race_id,
                        principalTable: "race",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_race_size_option_size_size_id",
                        column: x => x.size_id,
                        principalTable: "size",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_armor_category_proficiency",
                columns: table => new
                {
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    armor_category_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_armor_category_proficiency", x => new { x.class_id, x.armor_category_id });
                    table.ForeignKey(
                        name: "fk_class_armor_category_proficiency_armor_category_armor_catego~",
                        column: x => x.armor_category_id,
                        principalTable: "armor_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_armor_category_proficiency_class_class_id",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_saving_throw_proficiency",
                columns: table => new
                {
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ability_score_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_saving_throw_proficiency", x => new { x.class_id, x.ability_score_id });
                    table.ForeignKey(
                        name: "fk_class_saving_throw_proficiency_ability_score_ability_score_~",
                        column: x => x.ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_saving_throw_proficiency_class_class_id",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_starting_equipment_choice",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    option_order = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_starting_equipment_choice", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_starting_equipment_choice_class_class_id",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_weapon_category_proficiency",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_category_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_weapon_category_proficiency", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_weapon_category_proficiency_class_class_id",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_weapon_category_proficiency_weapon_category_weapon_cat~",
                        column: x => x.weapon_category_id,
                        principalTable: "weapon_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sub_class",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sub_class", x => x.id);
                    table.ForeignKey(
                        name: "fk_sub_class_class_class_id",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "background_skill_proficiency",
                columns: table => new
                {
                    background_id = table.Column<Guid>(type: "uuid", nullable: false),
                    skill_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_background_skill_proficiency", x => new { x.background_id, x.skill_id });
                    table.ForeignKey(
                        name: "fk_background_skill_proficiency_background_background_id",
                        column: x => x.background_id,
                        principalTable: "background",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_background_skill_proficiency_skill_skill_id",
                        column: x => x.skill_id,
                        principalTable: "skill",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "background_ability_score_option",
                columns: table => new
                {
                    background_ability_score_choice_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ability_score_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_background_ability_score_option", x => new { x.background_ability_score_choice_id, x.ability_score_id });
                    table.ForeignKey(
                        name: "fk_background_ability_score_option_ability_score_ability_score~",
                        column: x => x.ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_background_ability_score_option_background_ability_score_ch~",
                        column: x => x.background_ability_score_choice_id,
                        principalTable: "background_ability_score_choice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "feat_benefit",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    feat_id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false),
                    skill_proficiency_choice_amount = table.Column<byte>(type: "smallint", nullable: true),
                    tool_proficiency_choice_amount = table.Column<byte>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_feat_benefit", x => x.id);
                    table.ForeignKey(
                        name: "fk_feat_benefit_feat_feat_id",
                        column: x => x.feat_id,
                        principalTable: "feat",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_skill_proficiency_option",
                columns: table => new
                {
                    race_skill_proficiency_choice_id = table.Column<Guid>(type: "uuid", nullable: false),
                    skill_id = table.Column<Guid>(type: "uuid", nullable: false),
                    is_expertise = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_skill_proficiency_option", x => new { x.race_skill_proficiency_choice_id, x.skill_id });
                    table.ForeignKey(
                        name: "fk_race_skill_proficiency_option_race_skill_proficiency_choice~",
                        column: x => x.race_skill_proficiency_choice_id,
                        principalTable: "race_skill_proficiency_choice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_race_skill_proficiency_option_skill_skill_id",
                        column: x => x.skill_id,
                        principalTable: "skill",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_ancestry_spell",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    race_ancestry_id = table.Column<Guid>(type: "uuid", nullable: false),
                    spell_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_ancestry_spell", x => x.id);
                    table.ForeignKey(
                        name: "fk_race_ancestry_spell_race_ancestry_race_ancestry_id",
                        column: x => x.race_ancestry_id,
                        principalTable: "race_ancestry",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_race_ancestry_spell_spell_spell_id",
                        column: x => x.spell_id,
                        principalTable: "spell",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_cantrip",
                columns: table => new
                {
                    spell_id = table.Column<Guid>(type: "uuid", nullable: false),
                    race_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_cantrip", x => new { x.race_id, x.spell_id });
                    table.ForeignKey(
                        name: "fk_race_cantrip_race_race_id",
                        column: x => x.race_id,
                        principalTable: "race",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_race_cantrip_spell_spell_id",
                        column: x => x.spell_id,
                        principalTable: "spell",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_trait_spell",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    race_trait_id = table.Column<Guid>(type: "uuid", nullable: false),
                    spell_id = table.Column<Guid>(type: "uuid", nullable: false),
                    required_level = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_trait_spell", x => x.id);
                    table.ForeignKey(
                        name: "fk_race_trait_spell_race_trait_race_trait_id",
                        column: x => x.race_trait_id,
                        principalTable: "race_trait",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_race_trait_spell_spell_spell_id",
                        column: x => x.spell_id,
                        principalTable: "spell",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_weapon_category_proficiency_condition",
                columns: table => new
                {
                    class_weapon_category_proficiency_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_property_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_weapon_category_proficiency_condition", x => new { x.class_weapon_category_proficiency_id, x.weapon_property_id });
                    table.ForeignKey(
                        name: "fk_class_weapon_category_proficiency_condition_class_weapon_ca~",
                        column: x => x.class_weapon_category_proficiency_id,
                        principalTable: "class_weapon_category_proficiency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_weapon_category_proficiency_condition_weapon_property_~",
                        column: x => x.weapon_property_id,
                        principalTable: "weapon_property",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_level",
                columns: table => new
                {
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    level_id = table.Column<Guid>(type: "uuid", nullable: false),
                    proficiency_bonus = table.Column<byte>(type: "smallint", nullable: false),
                    sub_class_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_level", x => new { x.level_id, x.class_id });
                    table.ForeignKey(
                        name: "fk_class_level_class_class_id",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_level_level_level_id",
                        column: x => x.level_id,
                        principalTable: "level",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_level_sub_class_sub_class_id",
                        column: x => x.sub_class_id,
                        principalTable: "sub_class",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "class_skill_proficiency_choice",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    sub_class_id = table.Column<Guid>(type: "uuid", nullable: true),
                    allowed_choices = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_skill_proficiency_choice", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_skill_proficiency_choice_class_class_id",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_skill_proficiency_choice_sub_class_sub_class_id",
                        column: x => x.sub_class_id,
                        principalTable: "sub_class",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "class_spell",
                columns: table => new
                {
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    spell_id = table.Column<Guid>(type: "uuid", nullable: false),
                    sub_class_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_spell", x => new { x.class_id, x.spell_id });
                    table.ForeignKey(
                        name: "fk_class_spell_class_class_id",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_spell_spell_spell_id",
                        column: x => x.spell_id,
                        principalTable: "spell",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_spell_sub_class_sub_class_id",
                        column: x => x.sub_class_id,
                        principalTable: "sub_class",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "class_tool_proficiency_choice",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    sub_class_id = table.Column<Guid>(type: "uuid", nullable: true),
                    allowed_choices = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_tool_proficiency_choice", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_tool_proficiency_choice_class_class_id",
                        column: x => x.class_id,
                        principalTable: "class",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_tool_proficiency_choice_sub_class_sub_class_id",
                        column: x => x.sub_class_id,
                        principalTable: "sub_class",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "feat_benefit_skill_proficiency",
                columns: table => new
                {
                    feat_benefit_id = table.Column<Guid>(type: "uuid", nullable: false),
                    skill_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_feat_benefit_skill_proficiency", x => new { x.feat_benefit_id, x.skill_id });
                    table.ForeignKey(
                        name: "fk_feat_benefit_skill_proficiency_feat_benefit_feat_benefit_id",
                        column: x => x.feat_benefit_id,
                        principalTable: "feat_benefit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_feat_benefit_skill_proficiency_skill_skill_id",
                        column: x => x.skill_id,
                        principalTable: "skill",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_ancestry_spell_level",
                columns: table => new
                {
                    race_ancestry_spell_id = table.Column<Guid>(type: "uuid", nullable: false),
                    level_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_ancestry_spell_level", x => new { x.race_ancestry_spell_id, x.level_id });
                    table.ForeignKey(
                        name: "fk_race_ancestry_spell_level_level_level_id",
                        column: x => x.level_id,
                        principalTable: "level",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_race_ancestry_spell_level_race_ancestry_spell_race_ancestry~",
                        column: x => x.race_ancestry_spell_id,
                        principalTable: "race_ancestry_spell",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "race_trait_spell_level",
                columns: table => new
                {
                    race_trait_spell_id = table.Column<Guid>(type: "uuid", nullable: false),
                    level_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_race_trait_spell_level", x => new { x.race_trait_spell_id, x.level_id });
                    table.ForeignKey(
                        name: "fk_race_trait_spell_level_level_level_id",
                        column: x => x.level_id,
                        principalTable: "level",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_race_trait_spell_level_race_trait_spell_race_trait_spell_id",
                        column: x => x.race_trait_spell_id,
                        principalTable: "race_trait_spell",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_feature",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    level_id = table.Column<Guid>(type: "uuid", nullable: false),
                    parent_class_feature_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_feature", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_feature_class_feature_parent_class_feature_id",
                        column: x => x.parent_class_feature_id,
                        principalTable: "class_feature",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_class_feature_class_level_level_id_class_id",
                        columns: x => new { x.level_id, x.class_id },
                        principalTable: "class_level",
                        principalColumns: new[] { "level_id", "class_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_skill_proficiency_option",
                columns: table => new
                {
                    class_skill_proficiency_choice_id = table.Column<Guid>(type: "uuid", nullable: false),
                    skill_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_skill_proficiency_option", x => new { x.class_skill_proficiency_choice_id, x.skill_id });
                    table.ForeignKey(
                        name: "fk_class_skill_proficiency_option_class_skill_proficiency_choi~",
                        column: x => x.class_skill_proficiency_choice_id,
                        principalTable: "class_skill_proficiency_choice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_skill_proficiency_option_skill_skill_id",
                        column: x => x.skill_id,
                        principalTable: "skill",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_feature_attribute",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_feature_id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "varchar", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_feature_attribute", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_feature_attribute_class_feature_class_feature_id",
                        column: x => x.class_feature_id,
                        principalTable: "class_feature",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_feature_attribute_level",
                columns: table => new
                {
                    class_feature_attribute_id = table.Column<Guid>(type: "uuid", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false),
                    level_id = table.Column<Guid>(type: "uuid", nullable: false),
                    dice_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    value = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_feature_attribute_level", x => new { x.class_feature_attribute_id, x.class_id, x.level_id });
                    table.ForeignKey(
                        name: "fk_class_feature_attribute_level_class_feature_attribute_class~",
                        column: x => x.class_feature_attribute_id,
                        principalTable: "class_feature_attribute",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_feature_attribute_level_class_level_level_id_class_id",
                        columns: x => new { x.level_id, x.class_id },
                        principalTable: "class_level",
                        principalColumns: new[] { "level_id", "class_id" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_feature_attribute_level_dice_type_dice_type_id",
                        column: x => x.dice_type_id,
                        principalTable: "dice_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ammunitiontype",
                schema: "pk_ammunitiontype",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    amount = table.Column<byte>(type: "smallint", nullable: false),
                    storage = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    currency_type_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_ammunitiontype_currency_type_currency_type_id",
                        column: x => x.currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item",
                schema: "pk_item",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    cost_currency_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    name = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    cost = table.Column<decimal>(type: "decimal", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: true),
                    ammunition_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_item_ammunitiontype_ammunition_type_id",
                        column: x => x.ammunition_type_id,
                        principalSchema: "pk_ammunitiontype",
                        principalTable: "ammunitiontype",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_item_currency_type_cost_currency_type_id",
                        column: x => x.cost_currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_item_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "armor",
                schema: "pk_armor",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    armor_category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    required_ability_score_id = table.Column<Guid>(type: "uuid", nullable: true),
                    required_ability_score_minimum = table.Column<byte>(type: "smallint", nullable: false),
                    disadvantage_on_stealth = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_armor_ability_score_required_ability_score_id",
                        column: x => x.required_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_armor_armor_category_armor_category_id",
                        column: x => x.armor_category_id,
                        principalTable: "armor_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_armor_item_id",
                        column: x => x.id,
                        principalSchema: "pk_item",
                        principalTable: "item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "background_equipment_option_item",
                columns: table => new
                {
                    background_equipment_option_id = table.Column<Guid>(type: "uuid", nullable: false),
                    item_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_background_equipment_option_item", x => new { x.background_equipment_option_id, x.item_id });
                    table.ForeignKey(
                        name: "fk_background_equipment_option_item_background_equipment_optio~",
                        column: x => x.background_equipment_option_id,
                        principalTable: "background_equipment_option",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_background_equipment_option_item_item_item_id",
                        column: x => x.item_id,
                        principalSchema: "pk_item",
                        principalTable: "item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_starting_equipment_item",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    starting_equipment_option_id = table.Column<Guid>(type: "uuid", nullable: false),
                    item_id = table.Column<Guid>(type: "uuid", nullable: true),
                    currency_type_id = table.Column<Guid>(type: "uuid", nullable: true),
                    quantity = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_starting_equipment_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_starting_equipment_item_class_starting_equipment_choi~",
                        column: x => x.starting_equipment_option_id,
                        principalTable: "class_starting_equipment_choice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_starting_equipment_item_currency_type_currency_type_id",
                        column: x => x.currency_type_id,
                        principalTable: "currency_type",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_class_starting_equipment_item_item_item_id",
                        column: x => x.item_id,
                        principalSchema: "pk_item",
                        principalTable: "item",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "gear",
                schema: "pk_gear",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_gear_item_id",
                        column: x => x.id,
                        principalSchema: "pk_item",
                        principalTable: "item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tool",
                schema: "pk_tool",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    check_ability_score_id = table.Column<Guid>(type: "uuid", nullable: true),
                    description = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_tool_ability_score_check_ability_score_id",
                        column: x => x.check_ability_score_id,
                        principalTable: "ability_score",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_tool_item_id",
                        column: x => x.id,
                        principalSchema: "pk_item",
                        principalTable: "item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    item_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_mastery_property_id = table.Column<Guid>(type: "uuid", nullable: false),
                    base_ability_score_id = table.Column<Guid>(type: "uuid", nullable: false),
                    game_system_version_id = table.Column<Guid>(type: "uuid", nullable: true)
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
                        name: "fk_weapon_game_system_version_game_system_version_id",
                        column: x => x.game_system_version_id,
                        principalTable: "game_system_version",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_weapon_item_item_id",
                        column: x => x.item_id,
                        principalSchema: "pk_item",
                        principalTable: "item",
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
                name: "shieldarmor",
                schema: "pk_shieldarmor",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    armor_class_bonus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_shieldarmor_armor_id",
                        column: x => x.id,
                        principalSchema: "pk_armor",
                        principalTable: "armor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wearablearmor",
                schema: "pk_wearablearmor",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    armor_class_ability_score_modifier_id = table.Column<Guid>(type: "uuid", nullable: true),
                    base_armor_class = table.Column<byte>(type: "smallint", nullable: false),
                    applies_ability_modifier = table.Column<bool>(type: "boolean", nullable: false),
                    max_ability_modifier = table.Column<byte>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_item", x => x.id);
                    table.ForeignKey(
                        name: "fk_wearablearmor_ability_score_armor_class_ability_score_modif~",
                        column: x => x.armor_class_ability_score_modifier_id,
                        principalTable: "ability_score",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_wearablearmor_armor_id",
                        column: x => x.id,
                        principalSchema: "pk_armor",
                        principalTable: "armor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "background_tool_proficiency_option",
                columns: table => new
                {
                    background_tool_proficiency_choice_id = table.Column<Guid>(type: "uuid", nullable: false),
                    gear_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_background_tool_proficiency_option", x => new { x.background_tool_proficiency_choice_id, x.gear_id });
                    table.ForeignKey(
                        name: "fk_background_tool_proficiency_option_background_tool_proficie~",
                        column: x => x.background_tool_proficiency_choice_id,
                        principalTable: "background_tool_proficiency_choice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_background_tool_proficiency_option_gear_gear_id",
                        column: x => x.gear_id,
                        principalSchema: "pk_gear",
                        principalTable: "gear",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "background_tool_proficiency",
                columns: table => new
                {
                    background_id = table.Column<Guid>(type: "uuid", nullable: false),
                    tool_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_background_tool_proficiency", x => x.background_id);
                    table.ForeignKey(
                        name: "fk_background_tool_proficiency_background_background_id",
                        column: x => x.background_id,
                        principalTable: "background",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_background_tool_proficiency_tool_tool_id",
                        column: x => x.tool_id,
                        principalSchema: "pk_tool",
                        principalTable: "tool",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_tool_proficiency_option",
                columns: table => new
                {
                    class_tool_proficiency_choice_id = table.Column<Guid>(type: "uuid", nullable: false),
                    tool_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_tool_proficiency_option", x => new { x.class_tool_proficiency_choice_id, x.tool_id });
                    table.ForeignKey(
                        name: "fk_class_tool_proficiency_option_class_tool_proficiency_choice~",
                        column: x => x.class_tool_proficiency_choice_id,
                        principalTable: "class_tool_proficiency_choice",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_tool_proficiency_option_tool_tool_id",
                        column: x => x.tool_id,
                        principalSchema: "pk_tool",
                        principalTable: "tool",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "feat_benefit_tool_proficiency",
                columns: table => new
                {
                    feat_benefit_id = table.Column<Guid>(type: "uuid", nullable: false),
                    tool_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_feat_benefit_tool_proficiency", x => new { x.feat_benefit_id, x.tool_id });
                    table.ForeignKey(
                        name: "fk_feat_benefit_tool_proficiency_feat_benefit_feat_benefit_id",
                        column: x => x.feat_benefit_id,
                        principalTable: "feat_benefit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_feat_benefit_tool_proficiency_tool_tool_id",
                        column: x => x.tool_id,
                        principalSchema: "pk_tool",
                        principalTable: "tool",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weapon_damage",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    weapon_id = table.Column<Guid>(type: "uuid", nullable: false),
                    damage_type_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_damage", x => x.id);
                    table.ForeignKey(
                        name: "fk_weapon_damage_damage_type_damage_type_id",
                        column: x => x.damage_type_id,
                        principalTable: "damage_type",
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
                        name: "fk_weapon_property_attribute_ammunitiontype_ammunition_type_id",
                        column: x => x.ammunition_type_id,
                        principalSchema: "pk_ammunitiontype",
                        principalTable: "ammunitiontype",
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

            migrationBuilder.CreateTable(
                name: "weapon_damage_dice_type",
                columns: table => new
                {
                    weapon_damage_id = table.Column<Guid>(type: "uuid", nullable: false),
                    dice_type_id = table.Column<Guid>(type: "uuid", nullable: false),
                    quantity = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapon_damage_dice_type", x => new { x.weapon_damage_id, x.dice_type_id });
                    table.ForeignKey(
                        name: "fk_weapon_damage_dice_type_dice_type_dice_type_id",
                        column: x => x.dice_type_id,
                        principalTable: "dice_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_weapon_damage_dice_type_weapon_damage_weapon_damage_id",
                        column: x => x.weapon_damage_id,
                        principalTable: "weapon_damage",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("cd9c725d-11ab-40bc-8f2b-421f4d76f12c"), "Role with limited permissions.", "Admin" },
                    { new Guid("db54ffbc-5a1d-4246-9ec7-877aaa97c327"), "Role with all permissions.", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created_at", "email", "name", "password_hash" },
                values: new object[] { new Guid("148e0c53-ad6b-4974-ad15-eb220b27f74d"), new DateTime(2026, 3, 29, 23, 19, 46, 967, DateTimeKind.Local).AddTicks(686), "Y6ccCRFeZ70bOojKzt/gg3tg2/qNrU7YgsJ3rJaGlUc=", "IOJBj9szK9e3gUqfpF2J6w==", "$2a$11$ukLGLiiHySJpqOz.f5VCEuA/BA6PM2VlRUqmVqiKAa5lqxk.KTQ2C" });

            migrationBuilder.CreateIndex(
                name: "IX_ability_score_game_system_version_id",
                table: "ability_score",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_alignment_game_system_version_id",
                table: "alignment",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_ammunitiontype_currency_type_id",
                schema: "pk_ammunitiontype",
                table: "ammunitiontype",
                column: "currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_armor_armor_category_id",
                schema: "pk_armor",
                table: "armor",
                column: "armor_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_armor_required_ability_score_id",
                schema: "pk_armor",
                table: "armor",
                column: "required_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_armor_category_game_system_version_id",
                table: "armor_category",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_background_game_system_version_id",
                table: "background",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_background_ability_score_choice_background_id",
                table: "background_ability_score_choice",
                column: "background_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_background_ability_score_option_ability_score_id",
                table: "background_ability_score_option",
                column: "ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_background_equipment_option_background_id",
                table: "background_equipment_option",
                column: "background_id");

            migrationBuilder.CreateIndex(
                name: "IX_background_equipment_option_item_item_id",
                table: "background_equipment_option_item",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_background_skill_proficiency_skill_id",
                table: "background_skill_proficiency",
                column: "skill_id");

            migrationBuilder.CreateIndex(
                name: "IX_background_tool_proficiency_tool_id",
                table: "background_tool_proficiency",
                column: "tool_id");

            migrationBuilder.CreateIndex(
                name: "IX_background_tool_proficiency_choice_background_id",
                table: "background_tool_proficiency_choice",
                column: "background_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_background_tool_proficiency_option_gear_id",
                table: "background_tool_proficiency_option",
                column: "gear_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_game_system_version_id",
                table: "class",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_hit_dice_type_id",
                table: "class",
                column: "hit_dice_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_primary_ability_score_id",
                table: "class",
                column: "primary_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_armor_category_proficiency_armor_category_id",
                table: "class_armor_category_proficiency",
                column: "armor_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_feature_level_id_class_id",
                table: "class_feature",
                columns: new[] { "level_id", "class_id" });

            migrationBuilder.CreateIndex(
                name: "IX_class_feature_parent_class_feature_id",
                table: "class_feature",
                column: "parent_class_feature_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_feature_attribute_class_feature_id",
                table: "class_feature_attribute",
                column: "class_feature_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_feature_attribute_level_dice_type_id",
                table: "class_feature_attribute_level",
                column: "dice_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_feature_attribute_level_level_id_class_id",
                table: "class_feature_attribute_level",
                columns: new[] { "level_id", "class_id" });

            migrationBuilder.CreateIndex(
                name: "IX_class_level_class_id",
                table: "class_level",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_level_sub_class_id",
                table: "class_level",
                column: "sub_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_saving_throw_proficiency_ability_score_id",
                table: "class_saving_throw_proficiency",
                column: "ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_skill_proficiency_choice_class_id",
                table: "class_skill_proficiency_choice",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_skill_proficiency_choice_sub_class_id",
                table: "class_skill_proficiency_choice",
                column: "sub_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_skill_proficiency_option_skill_id",
                table: "class_skill_proficiency_option",
                column: "skill_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_spell_spell_id",
                table: "class_spell",
                column: "spell_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_spell_sub_class_id",
                table: "class_spell",
                column: "sub_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_starting_equipment_choice_class_id",
                table: "class_starting_equipment_choice",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_starting_equipment_item_currency_type_id",
                table: "class_starting_equipment_item",
                column: "currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_starting_equipment_item_item_id",
                table: "class_starting_equipment_item",
                column: "item_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_starting_equipment_item_starting_equipment_option_id",
                table: "class_starting_equipment_item",
                column: "starting_equipment_option_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_tool_proficiency_choice_class_id",
                table: "class_tool_proficiency_choice",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_tool_proficiency_choice_sub_class_id",
                table: "class_tool_proficiency_choice",
                column: "sub_class_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_tool_proficiency_option_tool_id",
                table: "class_tool_proficiency_option",
                column: "tool_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_weapon_category_proficiency_class_id",
                table: "class_weapon_category_proficiency",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_weapon_category_proficiency_weapon_category_id",
                table: "class_weapon_category_proficiency",
                column: "weapon_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_class_weapon_category_proficiency_condition_weapon_property~",
                table: "class_weapon_category_proficiency_condition",
                column: "weapon_property_id");

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
                name: "IX_feat_feat_category_id",
                table: "feat",
                column: "feat_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_feat_game_system_version_id",
                table: "feat",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_feat_benefit_feat_id",
                table: "feat_benefit",
                column: "feat_id");

            migrationBuilder.CreateIndex(
                name: "IX_feat_benefit_skill_proficiency_skill_id",
                table: "feat_benefit_skill_proficiency",
                column: "skill_id");

            migrationBuilder.CreateIndex(
                name: "IX_feat_benefit_tool_proficiency_tool_id",
                table: "feat_benefit_tool_proficiency",
                column: "tool_id");

            migrationBuilder.CreateIndex(
                name: "IX_feat_category_game_system_version_id",
                table: "feat_category",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_feature_game_system_version_id",
                table: "feature",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_game_system_version_game_system_id",
                table: "game_system_version",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_ammunition_type_id",
                schema: "pk_item",
                table: "item",
                column: "ammunition_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_cost_currency_type_id",
                schema: "pk_item",
                table: "item",
                column: "cost_currency_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_game_system_version_id",
                schema: "pk_item",
                table: "item",
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
                name: "IX_race_game_system_version_id",
                table: "race",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_parent_race_id",
                table: "race",
                column: "parent_race_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_ability_score_ability_score_id",
                table: "race_ability_score",
                column: "ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_ability_score_race_id",
                table: "race_ability_score",
                column: "race_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_ancestry_race_id",
                table: "race_ancestry",
                column: "race_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_ancestry_spell_race_ancestry_id",
                table: "race_ancestry_spell",
                column: "race_ancestry_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_ancestry_spell_spell_id",
                table: "race_ancestry_spell",
                column: "spell_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_ancestry_spell_level_level_id",
                table: "race_ancestry_spell_level",
                column: "level_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_cantrip_spell_id",
                table: "race_cantrip",
                column: "spell_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_language_language_id",
                table: "race_language",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_language_race_id",
                table: "race_language",
                column: "race_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_size_option_size_id",
                table: "race_size_option",
                column: "size_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_skill_proficiency_choice_race_id",
                table: "race_skill_proficiency_choice",
                column: "race_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_race_skill_proficiency_option_skill_id",
                table: "race_skill_proficiency_option",
                column: "skill_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_trait_race_id",
                table: "race_trait",
                column: "race_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_trait_spell_race_trait_id",
                table: "race_trait_spell",
                column: "race_trait_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_trait_spell_spell_id",
                table: "race_trait_spell",
                column: "spell_id");

            migrationBuilder.CreateIndex(
                name: "IX_race_trait_spell_level_level_id",
                table: "race_trait_spell_level",
                column: "level_id");

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
                name: "IX_spell_race_id",
                table: "spell",
                column: "race_id");

            migrationBuilder.CreateIndex(
                name: "IX_sub_class_class_id",
                table: "sub_class",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_tool_check_ability_score_id",
                schema: "pk_tool",
                table: "tool",
                column: "check_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_tool_category_game_system_id",
                table: "tool_category",
                column: "game_system_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_role_id",
                table: "user_role",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_base_ability_score_id",
                table: "weapon",
                column: "base_ability_score_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_game_system_version_id",
                table: "weapon",
                column: "game_system_version_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_item_id",
                table: "weapon",
                column: "item_id",
                unique: true);

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
                name: "IX_weapon_damage_weapon_id",
                table: "weapon_damage",
                column: "weapon_id");

            migrationBuilder.CreateIndex(
                name: "IX_weapon_damage_dice_type_dice_type_id",
                table: "weapon_damage_dice_type",
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
                name: "IX_wearablearmor_armor_class_ability_score_modifier_id",
                schema: "pk_wearablearmor",
                table: "wearablearmor",
                column: "armor_class_ability_score_modifier_id");

            migrationBuilder.AddForeignKey(
                name: "fk_ammunitiontype_gear_id",
                schema: "pk_ammunitiontype",
                table: "ammunitiontype",
                column: "id",
                principalSchema: "pk_gear",
                principalTable: "gear",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_currency_type_game_system_version_game_system_version_id",
                table: "currency_type");

            migrationBuilder.DropForeignKey(
                name: "fk_item_game_system_version_game_system_version_id",
                schema: "pk_item",
                table: "item");

            migrationBuilder.DropForeignKey(
                name: "fk_ammunitiontype_currency_type_currency_type_id",
                schema: "pk_ammunitiontype",
                table: "ammunitiontype");

            migrationBuilder.DropForeignKey(
                name: "fk_item_currency_type_cost_currency_type_id",
                schema: "pk_item",
                table: "item");

            migrationBuilder.DropForeignKey(
                name: "fk_ammunitiontype_gear_id",
                schema: "pk_ammunitiontype",
                table: "ammunitiontype");

            migrationBuilder.DropTable(
                name: "alignment");

            migrationBuilder.DropTable(
                name: "background_ability_score_option");

            migrationBuilder.DropTable(
                name: "background_equipment_option_item");

            migrationBuilder.DropTable(
                name: "background_skill_proficiency");

            migrationBuilder.DropTable(
                name: "background_tool_proficiency");

            migrationBuilder.DropTable(
                name: "background_tool_proficiency_option");

            migrationBuilder.DropTable(
                name: "class_armor_category_proficiency");

            migrationBuilder.DropTable(
                name: "class_feature_attribute_level");

            migrationBuilder.DropTable(
                name: "class_saving_throw_proficiency");

            migrationBuilder.DropTable(
                name: "class_skill_proficiency_option");

            migrationBuilder.DropTable(
                name: "class_spell");

            migrationBuilder.DropTable(
                name: "class_starting_equipment_item");

            migrationBuilder.DropTable(
                name: "class_tool_proficiency_option");

            migrationBuilder.DropTable(
                name: "class_weapon_category_proficiency_condition");

            migrationBuilder.DropTable(
                name: "currency_conversion_rate");

            migrationBuilder.DropTable(
                name: "feat_benefit_skill_proficiency");

            migrationBuilder.DropTable(
                name: "feat_benefit_tool_proficiency");

            migrationBuilder.DropTable(
                name: "feature");

            migrationBuilder.DropTable(
                name: "race_ability_score");

            migrationBuilder.DropTable(
                name: "race_ancestry_spell_level");

            migrationBuilder.DropTable(
                name: "race_cantrip");

            migrationBuilder.DropTable(
                name: "race_language");

            migrationBuilder.DropTable(
                name: "race_size_option");

            migrationBuilder.DropTable(
                name: "race_skill_proficiency_option");

            migrationBuilder.DropTable(
                name: "race_trait_spell_level");

            migrationBuilder.DropTable(
                name: "shieldarmor",
                schema: "pk_shieldarmor");

            migrationBuilder.DropTable(
                name: "tool_category");

            migrationBuilder.DropTable(
                name: "user_role");

            migrationBuilder.DropTable(
                name: "weapon_damage_dice_type");

            migrationBuilder.DropTable(
                name: "weapon_property_attribute");

            migrationBuilder.DropTable(
                name: "wearablearmor",
                schema: "pk_wearablearmor");

            migrationBuilder.DropTable(
                name: "background_ability_score_choice");

            migrationBuilder.DropTable(
                name: "background_equipment_option");

            migrationBuilder.DropTable(
                name: "background_tool_proficiency_choice");

            migrationBuilder.DropTable(
                name: "class_feature_attribute");

            migrationBuilder.DropTable(
                name: "class_skill_proficiency_choice");

            migrationBuilder.DropTable(
                name: "class_starting_equipment_choice");

            migrationBuilder.DropTable(
                name: "class_tool_proficiency_choice");

            migrationBuilder.DropTable(
                name: "class_weapon_category_proficiency");

            migrationBuilder.DropTable(
                name: "feat_benefit");

            migrationBuilder.DropTable(
                name: "tool",
                schema: "pk_tool");

            migrationBuilder.DropTable(
                name: "race_ancestry_spell");

            migrationBuilder.DropTable(
                name: "language");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropTable(
                name: "race_skill_proficiency_choice");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "race_trait_spell");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "weapon_damage");

            migrationBuilder.DropTable(
                name: "weapon_property");

            migrationBuilder.DropTable(
                name: "armor",
                schema: "pk_armor");

            migrationBuilder.DropTable(
                name: "background");

            migrationBuilder.DropTable(
                name: "class_feature");

            migrationBuilder.DropTable(
                name: "feat");

            migrationBuilder.DropTable(
                name: "race_ancestry");

            migrationBuilder.DropTable(
                name: "race_trait");

            migrationBuilder.DropTable(
                name: "spell");

            migrationBuilder.DropTable(
                name: "damage_type");

            migrationBuilder.DropTable(
                name: "weapon");

            migrationBuilder.DropTable(
                name: "armor_category");

            migrationBuilder.DropTable(
                name: "class_level");

            migrationBuilder.DropTable(
                name: "feat_category");

            migrationBuilder.DropTable(
                name: "race");

            migrationBuilder.DropTable(
                name: "weapon_category");

            migrationBuilder.DropTable(
                name: "weapon_mastery_property");

            migrationBuilder.DropTable(
                name: "weapon_type");

            migrationBuilder.DropTable(
                name: "level");

            migrationBuilder.DropTable(
                name: "sub_class");

            migrationBuilder.DropTable(
                name: "class");

            migrationBuilder.DropTable(
                name: "ability_score");

            migrationBuilder.DropTable(
                name: "dice_type");

            migrationBuilder.DropTable(
                name: "game_system_version");

            migrationBuilder.DropTable(
                name: "game_system");

            migrationBuilder.DropTable(
                name: "currency_type");

            migrationBuilder.DropTable(
                name: "gear",
                schema: "pk_gear");

            migrationBuilder.DropTable(
                name: "item",
                schema: "pk_item");

            migrationBuilder.DropTable(
                name: "ammunitiontype",
                schema: "pk_ammunitiontype");
        }
    }
}
