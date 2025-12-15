package com.lucaszottis.rpgcharactersheetmanager.entity

abstract class CharacterPersonalityEntity : EntityBase() {
    lateinit var backgroundId: String
    var name: String? = null
    lateinit var description: String
}