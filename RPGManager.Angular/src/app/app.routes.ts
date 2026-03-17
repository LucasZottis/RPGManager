import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path: "",
        loadComponent: () => import('./shared/layouts/main-layout/main-layout.component').then(p => p.MainLayoutComponent),
        children: [
            {
                path: "character-builder",
                loadComponent: () => import('./character-sheet-builder/character-sheet-builder-page/character-sheet-builder-page.component').then(p => p.CharacterSheetBuilderPageComponent),
            }
        ]
    }
];
