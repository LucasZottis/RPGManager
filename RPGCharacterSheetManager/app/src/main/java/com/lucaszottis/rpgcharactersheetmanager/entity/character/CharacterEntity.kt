package com.lucaszottis.rpgcharactersheetmanager.entity.character

import com.lucaszottis.rpgcharactersheetmanager.entity.EntityBase

class CharacterEntity : EntityBase() {
    lateinit var characterName: String
    var level: Int = 1
    lateinit var raceId: String
    lateinit var backgroundId: String
    lateinit var alignmentId: String

    var proeficiencyBonus: Int = 0
    var passiveWisdomPerception: Int = 0
    var armorClass: Int = 0
    var initiative: Int = 0
    var speed: Int = 0
    var hitPointMaximum: Int = 0
    var currentHitPoints: Int = 0
    var temporaryHitPoints: Int = 0
    var totalHitDice: Int = 0
    var usedHitDice: Int = 0
    var hitDice: Int = 0
    var deathSaveSuccess: Int = 0
    var deathSaveFailure: Int = 0

    lateinit var personalTrait: String
    lateinit var ideal: String
    lateinit var bonds: String
    lateinit var flaw: String

    //lateinit var Abilities: List<AbilityModel>
}