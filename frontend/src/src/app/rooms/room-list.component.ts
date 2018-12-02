import { Component, OnInit } from '@angular/core';
import { Room } from './room';

@Component({
    selector: 'room-list',
    templateUrl: './room-list.component.html',
    styleUrls: ['./room-list.component.sass']
})
export class RoomListComponent implements OnInit {
    public roomList: Room[];

    constructor() {
    }

    public ngOnInit(): void {
        this.roomList = [new Room('Küche', 'a'), new Room('Wohnzimmer', 'b')]
        
    }

    public ngOnDestroy() {
        this.roomList = null;
    }
}
