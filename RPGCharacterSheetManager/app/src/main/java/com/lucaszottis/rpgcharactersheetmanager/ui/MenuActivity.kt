package com.lucaszottis.rpgcharactersheetmanager.ui

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.lucaszottis.rpgcharactersheetmanager.R
import com.lucaszottis.rpgcharactersheetmanager.ui.characterbuilder.CharacterTraits
import com.lucaszottis.rpgcharactersheetmanager.databinding.ActivityMenuBinding

class MenuActivity : AppCompatActivity() {
    private lateinit var bindings: ActivityMenuBinding

    private fun initiateVariables() {
        bindings = ActivityMenuBinding.inflate(layoutInflater)
    }

    private fun onClickCreateNewCharacter() {
        val intent: Intent = Intent(this, CharacterTraits::class.java)
        startActivity(intent)
    }

    private fun onClickManageCharacter() {
        Toast.makeText(this, "Não implementado!", Toast.LENGTH_SHORT)
            .show()
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        initiateVariables()
        setContentView(bindings.root)

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        bindings.buttonCreateNewCharacter.setOnClickListener { onClickCreateNewCharacter() }
    }
}