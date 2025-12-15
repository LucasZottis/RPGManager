package com.lucaszottis.rpgcharactersheetmanager.ui.characterbuilder

import android.content.Intent
import android.os.Bundle
import android.view.View
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.lucaszottis.rpgcharactersheetmanager.R
import com.lucaszottis.rpgcharactersheetmanager.databinding.ActivityCharacterTraitsBinding

class CharacterTraits : AppCompatActivity() {
    private lateinit var bindings: ActivityCharacterTraitsBinding

    private fun initiateVariables() {
        bindings = ActivityCharacterTraitsBinding.inflate(layoutInflater)
    }

    private fun applyWindowsInsetsListener(view: View, insets: WindowInsetsCompat): WindowInsetsCompat {
        val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
        val defaultPadding = resources.getDimensionPixelSize(R.dimen.default_padding)

        view.setPadding(
            systemBars.left + defaultPadding,
            systemBars.top + defaultPadding,
            systemBars.right + defaultPadding,
            systemBars.bottom + defaultPadding
        )

        return insets
    }

    private fun onClickButtonNext() {
        val intent: Intent = Intent(this, CharactersPersonality::class.java)
        startActivity(intent)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        initiateVariables()
        setContentView(bindings.root)

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { view, insets ->
            applyWindowsInsetsListener(view, insets)
        }

        bindings.buttonNext.setOnClickListener { onClickButtonNext() }
    }
}