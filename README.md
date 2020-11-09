# DataVisualizer
A (planned to be) collection of utilities for visualizing data.

## Installation
Download a package from the Releases page, unpack and run it. Installation of .NET Core may be required.

## Usage
### Serial visualizer
Right now, the software only displays a histogram of the incoming data. It expects a comma-delimited string of numbers and each line of data will be treated as a new set which is then displayed.
For example:
```
50,100,250
100,75,225
90,125,210
```
Each line of the above example will cause the UI to update and display a visualization of it.

## License
**Based on** MIT License

Copyright (c) 2020 Marcel Diskowski ("cronoxyd")

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute and/or sublicense, and to 
permit persons to whom the Software is furnished to do so, subject to the 
following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software. And the mere obtainment of the
Software (including the associated documentation files and this license) is still
free of charge.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
