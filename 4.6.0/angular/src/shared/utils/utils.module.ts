import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
// ReuseTab scroll service
import { ScrollService } from './scroll.service';

@NgModule({
    imports: [
        CommonModule
    ],
    providers: [
        ScrollService,
    ],
    declarations: [
    ],
    exports: [
    ]
})
export class UtilsModule { }
