package com.lucaszottis.rpgcharactersheetmanager.entity.character

class CharacterAbilityEntity {
    lateinit var characterId: String
    lateinit var abilityId: String
    var hasProficiency: Boolean = false
    var value: Int = 0
}