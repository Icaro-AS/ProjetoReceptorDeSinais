import { Component, OnInit } from '@angular/core';
import {SignalRService} from '../services/signal-r.service'
import { SignalViewModel } from '../models/signal-view-model';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {

  signalList: SignalViewModel[] = [];

  constructor(private signalRService: SignalRService) { }

  ngOnInit() {
    this.signalRService.signalReceived.subscribe((signal: SignalViewModel) => {
      this.signalList.push(signal);
    });

  }
}
