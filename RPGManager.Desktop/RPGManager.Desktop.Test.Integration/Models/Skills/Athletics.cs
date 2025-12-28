



namespace RPGManager.Desktop.Test.Integration.Models.Skills;

public class Athletics : SkillModel
{
    public Athletics( Dictionaries rules )
    {
        Name = "Atletismo";
        Description = GetDescription();
        GameSystemId = rules.GamaSystem.Get( GameSystemKey.DND5E ).Id;
        ////BaseAbilityScore = baseAbilityScore;
    }

    private string GetDescription()
    {
        return @"<section class=""skill-description athletics"">
                <h3>Força (Atletismo)</h3>
                <p>
                    Um teste de Força (Atletismo) abrange as situações difíceis que você encontra ao escalar, 
                    saltar ou nadar. Os exemplos incluem as seguintes atividades:
                </p>

                <ul>
                <li>
                    Você tenta escalar um penhasco natural ou escorregadio, evitar perigos enquanto
                    escala uma parede, ou agarrar-se a uma superfície quando algo está tentando
                    derrubá-lo.
                </li>
                <li>
                    Você tenta saltar uma distância excepcionalmente longa ou executar um salto em
                    altura.
                </li>
                <li>
                    Você luta para nadar ou manter-se à tona em corredeiras traiçoeiras, ondas
                    agitadas pela tempestade ou áreas com algas espessas. Ou outra criatura tenta
                    empurrá-lo ou puxá-lo debaixo da água ou interferir de outra forma em sua natação.
                </li>
                </ul>
            </section>";
    }

}
