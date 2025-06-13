var resizeObserver: ResizeObserver;

function initialize(dotNetHelper: any, debug: boolean) {
    if (resizeObserver) {
        return;
    }

    if (window.ResizeObserver) {
        if (debug)
            console.debug("Creating ResizeObserver");

        resizeObserver = new ResizeObserver(entries => {
            for (const entry of entries) {
                let width: number;
                let height: number;

                // The standard makes contentBoxSize an array...
                if (entry.contentBoxSize[0]) {
                    width = entry.contentBoxSize[0].inlineSize;
                    height = entry.contentBoxSize[0].blockSize;
                } else {
                    // ...but old versions of Firefox treat it as a single item
                    width = entry.contentRect.width;
                    height = entry.contentRect.height;
                }

                dotNetHelper.invokeMethodAsync('OnResized', entry.target.id, height, width);
            }
        });
    }
    else {
        console.log('Resize observer not supported!');
    }
}

export function observe(ids: string[], dotNetHelper: any, debug: boolean) {
    initialize(dotNetHelper, debug);

    if (resizeObserver) {
        ids.forEach((id, index) => {
            const elem = <Element>document.getElementById(id);
            if (elem) {
                resizeObserver.observe(elem);
                if (debug) {
                    console.debug(`observe element where id = '${id}'`)
                }
            }
            else
                console.warn(`Element where id = '${id}' does not exist and will not be observed. `);
        });
    }
}

export function unobserve(ids: string[], debug: boolean) {
    if (resizeObserver) {
        ids.forEach((id, index) => {
            const elem = <Element>document.getElementById(id);
            if (elem)
            {
                resizeObserver.unobserve(elem);
                if (debug) {
                    console.debug(`unobserve element where id = '${id}'`)
                }
            }
            else
                console.warn(`Element where id = '${id}' does not exist and will not be unobserved. `);
        });
    }
}

export function disconnect(debug: boolean) {
    if (resizeObserver) {
        resizeObserver.disconnect();
        resizeObserver = null;
        if (debug) {
            console.debug("disconnect from ResizeObserver")
        }
    }
}
