import { OverlayModule } from '@angular/cdk/overlay';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { ReuseTabContextMenuComponent } from './reuse-tab-context-menu.component';
import { ReuseTabContextComponent } from './reuse-tab-context.component';
import { ReuseTabContextDirective } from './reuse-tab-context.directive';
import { ReuseTabComponent } from './reuse-tab.component';

const COMPONENTS = [ReuseTabComponent];
const NOEXPORTS = [ReuseTabContextMenuComponent, ReuseTabContextComponent, ReuseTabContextDirective];
import { MatMenuModule, MatTabsModule, MatIconModule, MatButtonModule } from '@angular/material';
@NgModule({
    imports: [CommonModule, RouterModule, MatMenuModule, MatTabsModule, MatIconModule, MatButtonModule, OverlayModule],
    declarations: [...COMPONENTS, ...NOEXPORTS],
    entryComponents: [ReuseTabContextMenuComponent],
    exports: [...COMPONENTS],
})
export class ReuseTabModule { }
