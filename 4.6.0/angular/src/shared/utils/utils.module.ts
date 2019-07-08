import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
// scroll service
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
