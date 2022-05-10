import { Component, OnInit } from '@angular/core';  
import { Chart } from 'chart.js';  
import { HttpClient } from '@angular/common/http';  
import { SignalViewModel } from '../models/signal-view-model';
import {SignalRService} from '../services/signal-r.service'

@Component({  
  selector: 'app-chart',  
  templateUrl: './chart.component.html',  
  styleUrls: ['./chart.component.css']  
})  
export class ChartComponent implements OnInit {  
  data: SignalViewModel[];  

  Tag = [];  
  Valor = [];  
  barchart:any = [];  
  signalList: SignalViewModel[] = [];

  constructor(private signalRService: SignalRService) { }  
  
  ngOnInit() {  
    this.signalRService.signalReceived.subscribe((signal: SignalViewModel) => {
      this.signalList.push(signal);
        this.Tag.push(Object(signal).tag);  
        this.Valor.push(parseInt(Object(signal).valor));  
 
   
      this  
      this.barchart = new Chart('canvas', {  
        type: 'bar',  
        data: {  
          labels: this.Tag,  
          datasets: [  
            {  
              data: this.Valor,
              borderColor: '#3cba9f',  
              backgroundColor: [  
                "#3cb371",  
                "#0000FF",  
                "#9966FF",  
                "#4C4CFF",  
                "#00FFFF",  
                "#f990a7",  
                "#aad2ed",  
                "#FF00FF",  
                "Blue",  
                "Red",  
                "Blue"  
              ],  
              fill: false  
            }  
          ]  
        },  
        options: {  
          legend: {  
            display: false  
          },  
          scales: {  
            xAxes: [{  
              display: true  
            }],  
            yAxes: [{  
              display: true  
            }],  
          }  
        }  
      });  
    });  
  }  
}  