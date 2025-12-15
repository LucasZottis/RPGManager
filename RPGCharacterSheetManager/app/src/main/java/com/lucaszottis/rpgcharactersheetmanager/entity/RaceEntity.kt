package com.lucaszottis.rpgcharactersheetmanager.entity

class RaceEntity : EntityBase() {
    lateinit var name: String
    lateinit var description: String
    var isSubRace: Boolean = false
}