import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';


import { RoomListComponent } from './room-list.component';

@NgModule({
    imports: [
        CommonModule,
        FormsModule],
    declarations: [
        RoomListComponent
    ],
    exports: [RoomListComponent]
})
export class RoomsModule { }