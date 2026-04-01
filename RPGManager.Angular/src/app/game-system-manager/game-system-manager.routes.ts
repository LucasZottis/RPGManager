import { Routes } from '@angular/router';

export const GAME_SYSTEM_MANAGER_ROUTES: Routes = [
    {
        path: "",
        loadComponent: () => import('../shared/layouts/main-layout/main-layout.component').then(p => p.MainLayoutComponent),
        children: [
            {
                path: "game-system",
                loadComponent: () => import('./pages/game-system-page/game-system-page.component').then(p => p.GameSystemPageComponent),
                // children: [
                //     {
                //         // path: ":gameSystemId/versions",
                //         // loadComponent: () => import('./pages/game-system-page/game-system-page.component').then(p => p.GameSystemPageComponent),
                //     },
                //     {
                //         // path: ":gameSystemId/version",
                //         // loadComponent: () => import('./pages/game-system-page/game-system-page.component').then(p => p.GameSystemPageComponent),
                //         children: [
                //             {
                //                 // path: ":versionId",
                //                 // loadComponent: () => import('./pages/game-system-page/game-system-page.component').then(p => p.GameSystemPageComponent),
                //                 children: [
                //                     {
                //                         // path: "edit",
                //                         // loadComponent: () => import('./pages/game-system-page/game-system-page.component').then(p => p.GameSystemPageComponent),
                //                         children: [

                //                         ]
                //                     },
                //                 ]
                //             },
                //             {
                //                 // path: "new",
                //                 // loadComponent: () => import('./pages/game-system-page/game-system-page.component').then(p => p.GameSystemPageComponent),
                //                 children: [
                //                     {
                //                         // path: ":gameSystemId/version/:versionId/edit",
                //                         // loadComponent: () => import('./pages/game-system-page/game-system-page.component').then(p => p.GameSystemPageComponent),
                //                         children: [

                //                         ]
                //                     },
                //                 ]
                //             },
                //         ]
                //     },
                // ]
            },
        ]
    }
];
