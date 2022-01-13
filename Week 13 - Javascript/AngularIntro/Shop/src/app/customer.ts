export class customer {
    name: string;
    currentFunds: number;
    homeState: string;
    hasCreditCard: boolean;

    constructor(name: string, currentFunds: number, homeState: string, hasCreditCard: boolean) {
        this.name = name;
        this.currentFunds = currentFunds;
        this.homeState = homeState;
        this.hasCreditCard = hasCreditCard
    }
}