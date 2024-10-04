export type PortfolioGet = {
    id: number;
    symbol: string;
    companyName: string;
    puchase: number;
    lastDiv: number;
    industry: string;
    marketCap: number;
    comments: any;
}

export type PortfolioPost = {
    symbol: string;
}